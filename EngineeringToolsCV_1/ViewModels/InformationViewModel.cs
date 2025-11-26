using EngineeringToolsCV_1.Command;
using EngineeringToolsCV_1.Models;
using EngineeringToolsCV_1.Repositories;
using EngineeringToolsCV_1.Service;
using EngineeringToolsCV_1.Store;
using EngineeringToolsCV_1.Views;
using System;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using System.Windows.Media.Imaging;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.IO;
using Microsoft.Win32;
using EngineeringToolsCV_1.DatabaseManager;

namespace EngineeringToolsCV_1.ViewModels
{
    public class InformationViewModel : ViewModelBase
    {
        private string ImagePath;
        private DbManager _dbManager;
        private UserInfos userInfosRepositories;
        private MStudentInformations _mStudentInfos;
        private MessageDialog dialogMessage;
        private DBName _dbName;
        private string strTitle;
        private string strName;
        private string strVorname;
        private string strEmail;
        private string strStraße;
        private string strPostleitzahl;
        private string strNummer;
        private string strLand;

        private string selectedCity;
        private DateTime strDate;
        private Brush colorTitle;
        private Brush colorName;
        private Brush colorVorname;
        private Brush colorStraße;
        private Brush colorNummer;
        private Brush colorPlz;
        private Brush colorCity;
        private Brush colorBirthplace;
        private Brush colorEmail;
        private Brush colorDate;
        private ImageSource _selectedImage;

        private ObservableCollection<string> cityList;

        private NavigationBarViewModel navigationBar;

        public ICommand NavigateCancelCommand { get; set; }
        public ICommand SaveCommand { get; set; }
        public ICommand LoadCommand { get; set; }

        public Brush ColorDate
        {
            get
            {
                return this.colorDate;
            }
            set
            {
                this.colorDate = value;
                OnPropertyChanged(nameof(this.ColorDate));
            }
        }


        public Brush ColorEmail
        {
            get
            {
                return this.colorEmail;
            }
            set
            {
                this.colorEmail = value;
                OnPropertyChanged(nameof(this.ColorEmail));
            }
        }

        public Brush ColorBirth
        {
            get
            {
                return this.colorBirthplace;
            }
            set
            {
                this.colorBirthplace = value;
                OnPropertyChanged(nameof(this.ColorBirth));
            }
        }

        public Brush ColorCity
        {
            get
            {
                return this.colorCity;
            }
            set
            {
                this.colorCity = value;
                OnPropertyChanged(nameof(this.ColorCity));
            }
        }

        public Brush ColorPlz
        {
            get
            {
                return this.colorPlz;
            }
            set
            {
                this.colorPlz = value;
                OnPropertyChanged(nameof(this.ColorPlz));
            }
        }

        public Brush ColorNummer
        {
            get
            {
                return this.colorNummer;
            }
            set
            {
                this.colorNummer = value;
                OnPropertyChanged(nameof(this.ColorNummer));
            }
        }

        public Brush ColorStraße
        {
            get
            {
                return this.colorStraße;
            }
            set
            {
                this.colorStraße = value;
                OnPropertyChanged(nameof(this.ColorStraße));
            }
        }

        public Brush ColorVorname
        {
            get
            {
                return this.colorVorname;
            }
            set
            {
                this.colorVorname = value;
                OnPropertyChanged(nameof(this.ColorVorname));
            }
        }

        public Brush ColorName
        {
            get
            {
                return this.colorName;
            }
            set
            {
                this.colorName = value;
                OnPropertyChanged(nameof(this.ColorName));
            }
        }

        public Brush ColorTitle
        {
            get
            {
                return this.colorTitle;
            }
            set
            {
                this.colorTitle = value;
                OnPropertyChanged(nameof(this.ColorTitle));
            }
        }

        public DateTime StrDate
        {
            get { return this.strDate; }
            set
            {
                this.strDate = value;
                this.OnPropertyChanged(nameof(this.StrDate));
            }
        }


        public string StrBirthPlace
        {
            get
            {
                return this.strLand;
            }
            set
            {
                this.strLand = value;
                OnPropertyChanged(nameof(this.StrBirthPlace));
            }
        }

        public string SelectedCity
        {
            get
            {
                return this.selectedCity;
            }
            set
            {
                this.selectedCity = value;
                OnPropertyChanged(nameof(this.SelectedCity));
            }
        }

        public string StrTitle
        {
            get
            {
                return this.strTitle;
            }
            set
            {
                this.strTitle = value;
                OnPropertyChanged(nameof(this.StrTitle));
            }
        }

        public string StrName
        {
            get
            {
                return this.strName;
            }
            set
            {
                this.strName = value;
                OnPropertyChanged(nameof(this.StrName));
            }
        }

        public string StrVorname
        {
            get
            {
                return this.strVorname;
            }
            set
            {
                this.strVorname = value;
                OnPropertyChanged(nameof(this.StrVorname));
            }
        }

        public string StrEmail
        {
            get
            {
                return this.strEmail;
            }
            set
            {
                this.strEmail = value;
                OnPropertyChanged(nameof(this.StrEmail));
            }
        }

        public string StrPostleitzahl
        {
            get
            {
                return this.strPostleitzahl;
            }
            set
            {
                this.strPostleitzahl = value;
                OnPropertyChanged(nameof(this.StrPostleitzahl));
            }
        }

        public string StrNummer
        {
            get
            {
                return this.strNummer;
            }
            set
            {
                this.strNummer = value;
                OnPropertyChanged(nameof(this.StrNummer));
            }
        }

        public string StrStraße
        {
            get
            {
                return this.strStraße;
            }
            set
            {
                this.strStraße = value;
                OnPropertyChanged(nameof(this.StrStraße));
            }
        }

        public ObservableCollection<string> CityList
        {
            get
            {
                return this.cityList;
            }

            set
            {
                this.cityList = value;
                OnPropertyChanged(nameof(CityList));
            }
        }

        public ImageSource SelectedImage
        {
            get => _selectedImage;
            set
            {
                _selectedImage = value;
                OnPropertyChanged(nameof(SelectedImage));
            }
        }

        public InformationViewModel(NavigationStore navigationStore, 
                                    MStudentInformations mStudentInfos,
                                    DbManager dbManager,
                                    DBName dbName )
        {
            this._mStudentInfos = mStudentInfos;
            this._dbManager = dbManager;
            this._dbName =  dbName;
            //this.userInfosRepositories = new UserInfos();
            this.strDate = new DateTime();
            CityList = new ObservableCollection<string>
            {
                "Salzgitter", "Braunschweig", "Hannover", "Hildesheim", "Salder"
            };

            this.ColorTitle = Brushes.Black;
            this.ColorName = Brushes.Black;
            this.ColorVorname = Brushes.Black;
            this.ColorStraße = Brushes.Black;
            this.ColorNummer = Brushes.Black;
            this.ColorPlz = Brushes.Black;
            this.ColorCity = Brushes.Black;
            this.ColorEmail = Brushes.Black;
            this.ColorDate = Brushes.Black;
            this.ColorBirth = Brushes.Black;

            this.executeCancelCommand(navigationStore);
            this.SaveCommand = new DelegateCommand(ExecuteSaveMethod, CanExecute);
            this.LoadCommand = new DelegateCommand(ExecuteLoadMethod, CanExecute);
        }

        public ImageSource Foto()
        {
            ImageSource imageSourceDefault = null;
            ImageSource imageSource;
           
            this.dialogMessage = new MessageDialog();
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image files (*.png;*.jpeg)|*.png;*.jpeg|All files (*.*)|*.*";
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            try
            {
                if (openFileDialog.ShowDialog() == true)
                {
                    ImagePath = openFileDialog.FileName;
                    imageSource = new BitmapImage(new Uri(ImagePath));
                    return imageSource;
                }
            }
            catch (Exception ex)
            {
                dialogMessage.ErrorMessage.Text = ex.Message.ToString();
            }

            return imageSourceDefault;
        }

        public byte[] ConvertImageToByte(Image img)
        {
            MemoryStream ms = new MemoryStream();
            //img.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
            return ms.ToArray();
        }

        public static string ByteArrayToHexString(byte[] bytes)
        {
            return "0x" + BitConverter.ToString(bytes).Replace("-", "");
        }

        private void ExecuteLoadMethod(object obj)
        {
            try
            {
                this.SelectedImage = this.Foto();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void executeCancelCommand(NavigationStore navigationStore)
        {
            navigationBar = new NavigationBarViewModel("Home -> Dashboard");

            NavigateCancelCommand = new NavigateCommand<DashboardViewModel>(
               new LayoutNavigationService<DashboardViewModel>(navigationStore,
               () => new DashboardViewModel(navigationStore,this._mStudentInfos,this._dbManager,this._dbName), navigationBar));
          
        }

        private bool CanExecute(object obj)
        {
            return true;
        }

        private void ExecuteSaveMethod(object obj)
        {
            int iCount;
           
            string filename = Path.GetFileName(ImagePath);
            string hexData = ByteArrayToHexString(File.ReadAllBytes(ImagePath));
            //this._UserInfo = new UserInfos();
            string strQueryRegister = string.Format("INSERT INTO {0} ({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11})" +
                                                     "VALUES('{12}','{13}','{14}','{15}','{16}','{17}','{18}','{19}','{20}','{21}','{22}')",
                                                     this._dbName.strTBL_StudentsInfo,this._dbName.strName,
                                                     this._dbName.strVorname, this._dbName.StrEmail,
                                                     this._dbName.strStraße, this._dbName.strNummer,
                                                     this._dbName.strPostleitzahl,this._dbName.strStadt,
                                                     this._dbName.strDatum,this._dbName.strLand,
                                                     this._dbName.strImageData,this._dbName.strFileName,
                                                     this.StrName, this.StrVorname, this.StrEmail,
                                                     this.StrStraße, this.StrNummer, 
                                                     this.StrPostleitzahl, this.SelectedCity, 
                                                     this.StrDate.ToString("yyyy-MM-dd"), this.StrBirthPlace,
                                                     hexData, filename );

            this.dialogMessage = new MessageDialog();
           try
            {
                if( string.IsNullOrEmpty(StrTitle) || string.IsNullOrEmpty(StrName)|| 
                    string.IsNullOrEmpty(StrVorname) || string.IsNullOrEmpty(StrEmail)|| 
                    string.IsNullOrEmpty(StrStraße) || string.IsNullOrEmpty(StrNummer) || 
                    string.IsNullOrEmpty(StrPostleitzahl) || string.IsNullOrEmpty(StrBirthPlace) ||
                    string.IsNullOrEmpty(this.SelectedCity) || string.IsNullOrEmpty(this.StrDate.ToString()))
                {
                    if (string.IsNullOrEmpty(StrTitle)){

                        this.ColorTitle = Brushes.Red;
                    }

                    if (string.IsNullOrEmpty(StrName)) {

                        this.ColorName = Brushes.Red;
                    }
                    
                    if (string.IsNullOrEmpty(StrVorname)){

                        this.ColorVorname = Brushes.Red;
                    }
                   
                    if (string.IsNullOrEmpty(StrEmail)){
                        this.ColorEmail = Brushes.Red;
                    }

                    if(string.IsNullOrEmpty(this.StrDate.ToString()))
                    {
                        this.ColorBirth = Brushes.Red;
                    }

                    if (string.IsNullOrEmpty(StrNummer))
                    {
                        this.ColorNummer = Brushes.Red;
                    }
                   
                    if(string.IsNullOrEmpty(StrPostleitzahl))
                    {
                        this.ColorPlz = Brushes.Red;
                    }
                   
                    if(string.IsNullOrEmpty(StrStraße))
                    {
                        this.ColorStraße = Brushes.Red;
                    }
                   
                    if (string.IsNullOrEmpty(this.SelectedCity))
                    {
                        this.ColorCity = Brushes.Red;
                    }
                   
                    if(string.IsNullOrEmpty(this.StrDate.ToString()))
                    {
                        this.ColorDate = Brushes.Red;
                    }

                    if (string.IsNullOrEmpty(this.StrBirthPlace))
                    {
                        this.ColorBirth = Brushes.Red;
                    }

                    this.dialogMessage.ErrorMessage.Text = "die leeren Feldern sollten ausgefüllt werden";
                    this.dialogMessage.Show();
                }
                else
                {
                    iCount = this._dbManager.SetAllInfos(strQueryRegister);
                    if (iCount == 1)
                    {
                        this.dialogMessage.ErrorMessage.Text = "die Einträgen wurden erfolgreich in die Datenbank hinzugefügt";
                        this.dialogMessage.Show();
                    }
                }               
            }
            catch (Exception ex)
            {
                this.dialogMessage.ErrorMessage.Text = ex.Message.ToString();
                this.dialogMessage.Show();
            }
            
        }
    }
}
