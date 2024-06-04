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

namespace EngineeringToolsCV_1.ViewModels
{
    public class InformationViewModel : ViewModelBase
    {
        private UserInfos _UserInfo;
        private MStudentInformations _mStudentInfos;
        private MessageDialog dialogMessage;
        private DBName DbName;
        private string strName;
        private string strVorname;
        private string strEmail;
        private string strStraße;
        private string strPostleitzahl;
        private string strNummer;
        private string selectedCity;

        private ObservableCollection<string> cityList;

        private NavigationBarViewModel navigationBar;

        public ICommand NavigateCancelCommand { get; set; }
        public ICommand SaveCommand { get; set; }

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
            CityList = new ObservableCollection<string>
            {
                "Salzgitter", "Braunschweig", "Hannover", "Hildesheim", "Salder"
            };

            this.executeCancelCommand(navigationStore);           
        }

        public void executeCancelCommand(NavigationStore navigationStore)
        {
            navigationBar = new NavigationBarViewModel("Home -> Dashboard");

            NavigateCancelCommand = new NavigateCommand<DashboardViewModel>(
               new LayoutNavigationService<DashboardViewModel>(navigationStore,
               () => new DashboardViewModel(navigationStore,this._mStudentInfos), navigationBar));

            this.SaveCommand = new DelegateCommand(ExecuteSaveMethod, CanExecute);
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
                iCount = this._UserInfo.SaveStudentInfos(strQueryRegister);
                if (iCount == 1)
                {
                    this.dialogMessage.ErrorMessage.Text = "die Einträgen wurden erfolgreich in die Datenbank hinzugefügt";
                    this.dialogMessage.Show();
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
