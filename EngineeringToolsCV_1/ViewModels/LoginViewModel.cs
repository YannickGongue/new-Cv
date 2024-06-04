using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using EngineeringToolsCV_1.Command;
using EngineeringToolsCV_1.IRepository;
using EngineeringToolsCV_1.Models;
using EngineeringToolsCV_1.Repositories;
using EngineeringToolsCV_1.Service;
using EngineeringToolsCV_1.Store;
using EngineeringToolsCV_1.Views;

namespace EngineeringToolsCV_1.ViewModels
{
    public class LoginViewModel : ViewModelBase
    {
        private string password;
        private string username;
        private bool setActivedWindow;
        private bool userResetEnabled;
        private RegisterView register;
        private UserResetView UserResetView;
        private RegisterViewModel _vmRegister;
        private UserResetViewModel _vmUserReset;
        private IUser userRepository;
        private MStudentInformations _mStudent;
        private NavigationBarViewModel navigationBar;

        public ViewModelCommand NavigateLoginCommand { get; }
        public ICommand RegisterCommand { get; }
        public ICommand UserResetCommand { get; }

        public bool UserResetEnabled
        {
            get { return this.userResetEnabled; }
            set
            {
                if (this.userResetEnabled != value)
                {
                    this.userResetEnabled = value;
                    this.OnPropertyChanged(nameof(UserResetEnabled));
                }
            }
        }
        public bool SetActivedWindow
        {
            get { return this.setActivedWindow; }
            set
            {
                if (this.setActivedWindow != value)
                {
                    this.setActivedWindow = value;
                    this.OnPropertyChanged(nameof(SetActivedWindow));
                }
            }
        }

        public string Username
        {
            get
            {
                return this.username;
            }

            set
            {
                this.username = value;
                OnPropertyChanged(nameof(Username));
            }
        }

        public string Password
        {
            get
            {
                return this.password;
            }

            set
            {
                this.password = value;
                OnPropertyChanged(nameof(Password));
            }
        }

        public LoginViewModel(NavigationStore navigateStore, RegisterViewModel vmRegister, 
                              UserResetViewModel vmUserReset, MStudentInformations mStudent)
        {
            this._vmRegister = vmRegister;
            this._vmUserReset = vmUserReset;
            this._mStudent = mStudent;
            this.navigationBar = new NavigationBarViewModel("Home -> Dashboard");

            this.SetActivedWindow = true;
            this.UserResetEnabled = true;

            this.NavigateLoginCommand = new NavigateLoginCommand(this,
                                   new LayoutNavigationService<DashboardViewModel>(navigateStore,
                                   () => new DashboardViewModel(navigateStore,this._mStudent), 
                                   navigationBar));
            this.RegisterCommand = new DelegateCommand(ExecuteRegister, CanExecute);
            this.UserResetCommand = new DelegateCommand(ExecuteUserReset, CanExecute);
        }

        private void ExecuteUserReset(object obj)
        {
            this.UserResetView = new UserResetView(this);
            this.UserResetEnabled = false;
            this.UserResetView.DataContext = new UserResetViewModel();
            this.UserResetView.Show(); 
            
        }

        private bool CanExecute(object obj)
        {
            return true;
        }

        private void ExecuteRegister(object obj)
        {
            this.register = new RegisterView(this);
            this.SetActivedWindow = false;
            this.register.DataContext = new RegisterViewModel();
             register.Show();               
           
        }
    }
}
