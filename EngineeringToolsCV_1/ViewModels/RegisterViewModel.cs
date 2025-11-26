using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using EngineeringToolsCV_1.Command;
using EngineeringToolsCV_1.IRepository;
using EngineeringToolsCV_1.Models;
using EngineeringToolsCV_1.Repositories;
using EngineeringToolsCV_1.DatabaseManager;

namespace EngineeringToolsCV_1.ViewModels
{
    public class RegisterViewModel : ViewModelBase
    {
       
        private string username;
        private string passwort;
        private string confirmPassword;
        private string emailAdresse;
        private LoginViewModel VmLogin;
        private DbManager _DbManager;
        private MUser mUser;
        private DBName dbname;



        public string Username
        {
            get
            {
                return this.username;
            }

            set
            {
                this.username = value;
                this.OnPropertyChanged(nameof(Username));
            }
        }

        public string Password
        {
            get
            {
                return this.passwort;
            }

            set
            {
                this.passwort = value;
                this.OnPropertyChanged(nameof(Password));
            }
        }

        public string ConfirmPassword
        {
            get
            {
                return this.confirmPassword;
            }

            set
            {
                this.confirmPassword = value;
                this.OnPropertyChanged(nameof(ConfirmPassword));
            }
        }

        public string EmailAdress
        {
            get
            {
                return this.emailAdresse;
            }

            set
            {
                this.emailAdresse = value;
                this.OnPropertyChanged(nameof(EmailAdress));
            }
        }

        public ICommand regCommand { get; }
        public ICommand CancelCommand { get; }

        public RegisterViewModel(LoginViewModel _vmLogin, MUser _mUser, DbManager dbManager)
        {
            this.mUser = _mUser;
            this._DbManager = dbManager;
            this.VmLogin = _vmLogin;
            this.regCommand = new DelegateCommand( regExecut, CanExecute);
            this.CancelCommand = new DelegateCommand(CancelExecut, CanExecute);

        }

        private void regExecut(object obj)
        {
            string strQueryRegister = string.Format("INSERT INTO {0} ({1},{2},{3}) VALUES('{1}','{2}','{3}')",
                                                  this.dbname.StrTBL_User,
                                                  this.dbname.StrId,
                                                  this.dbname.StrEmail,
                                                  this.dbname.StrPasswort);
           

            this.mUser.Id = this.Username;
            this.mUser.Email = this.EmailAdress;
            this.mUser.Passwort = this.Password;
            this.mUser.ConfirmPasswort = this.ConfirmPassword;

            this._DbManager.registerUser( strQueryRegister,mUser);
        }

        private void CancelExecut(object obj)
        {
            
        }

        private bool CanExecute(object obj)
        {
            return true;
        }

       
    }
}
