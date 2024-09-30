using EngineeringToolsCV_1.Command;
using EngineeringToolsCV_1.Models;
using EngineeringToolsCV_1.Repositories;
using EngineeringToolsCV_1.Service;
using EngineeringToolsCV_1.Store;
using EngineeringToolsCV_1.Style;
using EngineeringToolsCV_1.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using System.Windows.Media.Imaging;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace EngineeringToolsCV_1.ViewModels
{
    public class InformationViewModel : ViewModelBase
    {
        private UserInfos _UserInfo;
        private UserInfos userInfosRepositories;
        private MStudentInformations _mStudentInfos;
        private MessageDialog dialogMessage;
        private DBName DbName;
        private string strTitle;
        private string strName;
        private string strVorname;
        private string strEmail;
        private string strStraße;
        private string strPostleitzahl;
        private string strNummer;
        private string selectedCity;
        private DateTime strDate;
        private Brush colorTitle;
        private Brush colorName;
        private Brush colorVorname;
        private Brush colorStraße;
        private Brush colorNummer;
        private Brush colorPlz;
        private Brush colorCity;
        private Brush colorBirth;
        private Brush colorEmail;
        private Brush colorDate;


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
                return this.colorBirth;
            }
            set
            {
                this.colorBirth = value;
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
                OnPropertyChanged(nameof(this.strEmail));
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

        

        public InformationViewModel(NavigationStore navigationStore, MStudentInformations mStudentInfos)
        {
            this._mStudentInfos = mStudentInfos;
            DbName = new DBName();
            this.userInfosRepositories = new UserInfos();
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

            this.executeCancelCommand(navigationStore);
            this.SaveCommand = new DelegateCommand(ExecuteSaveMethod, CanExecute);
            //this.LoadCommand = new DelegateCommand(ExecuteLoadMethod, CanExecute);
        }

        //private void ExecuteLoadMethod(object obj)
        //{
        //    try
        //    {
        //        imageFoto.Source = this.userInfosRepositories.Foto();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}

        public void executeCancelCommand(NavigationStore navigationStore)
        {
            navigationBar = new NavigationBarViewModel("Home -> Dashboard");

            NavigateCancelCommand = new NavigateCommand<DashboardViewModel>(
               new LayoutNavigationService<DashboardViewModel>(navigationStore,
               () => new DashboardViewModel(navigationStore,this._mStudentInfos), navigationBar));
          
        }

        private bool CanExecute(object obj)
        {
            return true;
        }

        private void ExecuteSaveMethod(object obj)
        {
            int iCount;
            this._UserInfo = new UserInfos();
            string strQueryRegister = string.Format("INSERT INTO {0} ({1},{2},{3},{4},{5},{6},{7})" +
                                                     "VALUES({8},{9},{10},{11},{12},{13},{14})",
                                                     DbName.strTBL_StudentsInfo,DbName.strName,
                                                     DbName.strVorname, DbName.StrEmail,
                                                     DbName.strStraße, DbName.strNummer,
                                                     DbName.strPostleitzahl,DbName.strStadt,
                                                     this.StrName, this.StrVorname, this.StrEmail,
                                                     this.StrStraße, this.strNummer, this.StrPostleitzahl, this.SelectedCity);
            this.dialogMessage = new MessageDialog();
           try
            {
                if(string.IsNullOrEmpty(StrTitle) || string.IsNullOrEmpty(StrName)|| 
                    string.IsNullOrEmpty(StrVorname) || string.IsNullOrEmpty(StrEmail)|| 
                    string.IsNullOrEmpty(StrStraße) || string.IsNullOrEmpty(strNummer) || string.IsNullOrEmpty(StrPostleitzahl) ||
                    string.IsNullOrEmpty(this.SelectedCity) || string.IsNullOrEmpty(this.strDate.ToString()))
                {
                    this.ColorTitle = Brushes.Red;
                    this.ColorName = Brushes.Red;
                    this.ColorVorname = Brushes.Red;
                    this.ColorBirth = Brushes.Red;
                    this.ColorEmail = Brushes.Red;
                    this.ColorNummer = Brushes.Red;
                    this.ColorPlz = Brushes.Red;
                    this.ColorStraße = Brushes.Red;
                    this.ColorCity = Brushes.Red;
                    this.ColorDate = Brushes.Red;
                    this.dialogMessage.ErrorMessage.Text = "die Leeren Feldern sollten ausgefüllt werden";
                    this.dialogMessage.Show();
                }
                else
                {
                    iCount = this._UserInfo.SaveStudentInfos(strQueryRegister);
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
