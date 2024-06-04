using EngineeringToolsCV_1.Command;
using EngineeringToolsCV_1.Models;
using EngineeringToolsCV_1.Service;
using EngineeringToolsCV_1.Store;
using EngineeringToolsCV_1.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace EngineeringToolsCV_1.ViewModels
{
    public class HomeViewModel : ViewModelBase
    {
        private NavigationBarViewModel navigationBar;
        private RegisterViewModel _vmUserRegister;      
        private UserResetViewModel _vmUserReset;
        private MStudentInformations _mStudent;

        private string displayedImagePath = @"C:\Users\vamic\source\repos\EngineeringToolsCV_1\EngineeringToolsCV_1\Images\job-portfolio.png"; 
        public ICommand NavigateLoginCommand { get; }
       
        public string DisplayedImagePath
        {
            get { return this.displayedImagePath; }
            set 
            { 
                this.displayedImagePath = value;
                OnPropertyChanged(nameof(DisplayedImagePath));
            }
        }

        public HomeViewModel(NavigationStore navigationStore, RegisterViewModel userRegister, 
                              UserResetViewModel vmUserReset, MStudentInformations mStudent)
        {
            this._vmUserRegister = userRegister;
            this._vmUserReset = vmUserReset;
            this._mStudent = mStudent;
                                                                       
            navigationBar = new NavigationBarViewModel("Home");
            NavigateLoginCommand = new NavigateCommand<LoginViewModel>(
                new LayoutNavigationService<LoginViewModel>(navigationStore,
                () => new LoginViewModel(navigationStore,this._vmUserRegister,this._vmUserReset,this._mStudent), navigationBar));
        }
    }
}
