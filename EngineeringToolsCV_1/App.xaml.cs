using EngineeringToolsCV_1.Models;
using EngineeringToolsCV_1.Service;
using EngineeringToolsCV_1.Store;
using EngineeringToolsCV_1.ViewModels;
using EngineeringToolsCV_1.Views;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace EngineeringToolsCV_1
{
    /// <summaruserLoginy>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private string strServer;
        private string strDbname;
        private string strSecurity;
        private AppSetting setting;
        private string connectionString;
        private MainWindow mainWindow;
        private NavigationStore navigationStore;
        private NavigationBarViewModel _NavigationBar;
        private SQLServerView ServerView;
        private RegisterViewModel _vmRegister;
        private UserResetViewModel _vmUserReset;
        private MStudentInformations _mStudent;
       
        public App()
        {
           
            this._mStudent = new MStudentInformations();
            this._vmRegister = new RegisterViewModel();
            this._vmUserReset = new UserResetViewModel();
            this.navigationStore = new NavigationStore();
            this.mainWindow = new MainWindow();
            this._NavigationBar = new NavigationBarViewModel("Home");
            this.ServerView = new SQLServerView(this._vmRegister,this._vmUserReset,this._mStudent);
        }

        private void Application_Startup(object sender, StartupEventArgs e)
        {  
            if(Environment.MachineName.Equals("DESKTOP-5FKC835"))
            {
                setting = new AppSetting();
                strServer = @"(localdb)\MSSQLLocalDB";
                strDbname = "Lebenslauf";
                strSecurity = "SSPI";
                connectionString = String.Format("{0} {1} {2}", "server =" + strServer, "; Integrated Security =" + strSecurity, "; Initial Catalog =" + strDbname);
                setting.saveConnectionString("ConnectionString", connectionString);
               
                this.CreateHomeView();
            }
            else
            {
                ServerView.Show();
            }
        }

        private void CreateHomeView()
        {
            INavigateService<HomeViewModel> homeNavigationService = new LayoutNavigationService<HomeViewModel>(navigationStore,
                        () => new HomeViewModel(navigationStore, this._vmRegister, this._vmUserReset,this._mStudent), _NavigationBar);
            homeNavigationService.Navigate();
            this.mainWindow.DataContext = new mainViewModel(navigationStore, this._vmRegister,this._vmUserReset,this._mStudent);
            this.mainWindow.Show();
        }
        
    }
}
