
using EngineeringToolsCV_1.Models;
using EngineeringToolsCV_1.Repositories;
using EngineeringToolsCV_1.Service;
using EngineeringToolsCV_1.Store;
using EngineeringToolsCV_1.ViewModels;
using EngineeringToolsCV_1.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace EngineeringToolsCV_1.Command
{
    public class NavigateLoginCommand : ViewModelCommand
    {
        private MUser mUser;
        private User userRepositories;
        private LoginViewModel _ViewModel;
        private MessageDialog dialogMessage;
        private INavigateService<DashboardViewModel> _navigateService;

        public NavigateLoginCommand(LoginViewModel loginviewModel, 
                                    INavigateService<DashboardViewModel> navigateService)
        {
            _ViewModel = loginviewModel;
            _navigateService = navigateService;
        }

        public override void Execute(object parameter)
        {
            this.mUser = new MUser();
            this.userRepositories = new User();
            this.dialogMessage = new MessageDialog();

            mUser.Id = _ViewModel.Username;
            mUser.Passwort = _ViewModel.Password;
          
            if(userRepositories.LoginUser(mUser).Rows.Count==1)
            {
                _navigateService.Navigate();
            }
            else
            {
                this.dialogMessage.ErrorMessage.Text = "die Username und passwort sind nicht verfügbar";
                this.dialogMessage.Show();
            }
        }
    }
}
