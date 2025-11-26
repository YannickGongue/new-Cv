
using EngineeringToolsCV_1.DatabaseManager;
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
        private MUser _mUser;
        private LoginViewModel _ViewModel;
        private MessageDialog dialogMessage;
        private INavigateService<DashboardViewModel> _navigateService;
        private DbManager _dbManager;
        private DBName _dbName;

        public NavigateLoginCommand(LoginViewModel loginviewModel, 
                                    INavigateService<DashboardViewModel> navigateService,
                                    DbManager dbManager,
                                    MUser mUser,
                                    DBName dbName)
        {
            this._ViewModel = loginviewModel;
            this._navigateService = navigateService;
            this._dbManager = dbManager;
            this._mUser = mUser;
            this._dbName = dbName;
        }

        public override void Execute(object parameter)
        {
            this.dialogMessage = new MessageDialog();
           
          
            this._mUser.Id = _ViewModel.Username;
            this._mUser.Passwort = _ViewModel.Password;
            string strQueryLogin = String.Format("SELECT {1},{2} FROM {0} WHERE {1}= '{3}' AND {2}= '{4}'",
                                              this._dbName.StrTBL_User,
                                              this._dbName.StrId,
                                              this._dbName.StrPasswort,
                                              this._mUser.Id,
                                              this._mUser.Passwort);

            if (this._dbManager.GetUserDataFromDB(strQueryLogin).Rows.Count==1)
            {
                this._navigateService.Navigate();
            }
            else
            {
                this.dialogMessage.ErrorMessage.Text = "die Username und passwort sind nicht verfügbar";
                this.dialogMessage.Show();
            }
        }
    }
}
