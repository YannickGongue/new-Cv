
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
        private ErrorMessageViewModel _vmdialogMessage;

        public NavigateLoginCommand(LoginViewModel loginviewModel, 
                                    INavigateService<DashboardViewModel> navigateService,
                                    DbManager dbManager,
                                    MUser mUser,
                                    DBName dbName,
                                    ErrorMessageViewModel vmdialogMessage)
        {
            this._ViewModel = loginviewModel;
            this._navigateService = navigateService;
            this._dbManager = dbManager;
            this._mUser = mUser;
            this._dbName = dbName;
            this._vmdialogMessage = vmdialogMessage;

            this.dialogMessage = new MessageDialog();
        }

        public async override void Execute(object parameter)
        {
                              
            try
            {

                var table = await _dbManager.GetUserInfoAsync(_ViewModel.Username, _ViewModel.Password);

                if (table.Rows.Count == 1)
                {
                    this._navigateService.Navigate();
                }
                else
                {
                    this._vmdialogMessage.SetErrorMessage = "die Username und passwort sind nicht verfügbar";
                    this.dialogMessage.DataContext = this._vmdialogMessage;
                    this.dialogMessage.Show();
                }
            }
            catch (Exception ex)
            {
                this._vmdialogMessage.SetErrorMessage = $"Fehler beim Login:\n{ex.Message}";
                this.dialogMessage.DataContext = this._vmdialogMessage;
                this.dialogMessage.Show();
            }
        }
    }
}
