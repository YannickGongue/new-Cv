using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using EngineeringToolsCV_1.Command;
using EngineeringToolsCV_1.Models;
using EngineeringToolsCV_1.Repositories;

namespace EngineeringToolsCV_1.ViewModels
{
    public class RegisterViewModel : ViewModelBase
    {
       
        private string username;
        private string passwort;
        private string confirmPassword;
        private string emailAdresse;
        private LoginViewModel VmLogin;
        private User userRepositories;
        private MUser mUser;



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

        public RegisterViewModel(LoginViewModel _vmLogin, MUser _mUser)
        {
            this.mUser = _mUser;
            this.userRepositories = new User();
            
            this.VmLogin = _vmLogin;
            this.regCommand = new DelegateCommand( regExecut, CanExecute);
            this.CancelCommand = new DelegateCommand(CancelExecut, CanExecute);

        }

        private void regExecut(object obj)
        {
            this.mUser.Id = this.Username;
            this.mUser.Email = this.EmailAdress;
            this.mUser.Passwort = this.Password;
            this.mUser.ConfirmPasswort = this.ConfirmPassword;

            this.userRepositories.AddUser(mUser);
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
