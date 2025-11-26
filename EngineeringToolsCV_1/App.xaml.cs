using EngineeringToolsCV_1.Models;
using EngineeringToolsCV_1.Service;
using EngineeringToolsCV_1.Store;
using EngineeringToolsCV_1.ViewModels;
using EngineeringToolsCV_1.Views;
using EngineeringToolsCV_1.DatabaseManager;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Globalization;
using Haley.Utils;
using EngineeringToolsCV_1.Repositories;

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
        private MUser mUser;
        private LoginViewModel VmLogin;
        private NewPassordViewModel _vmNewPassword;
        private DbManager dbManager;
        private UserInfos _userInfo;
        private User _user;
        private SqlConnectionFactory sqlcon;
        private DBName dbName;


        public App()
        {
            string strConnectionString = ConfigurationManager
                                         .ConnectionStrings["ConnectionString"]
                                          .ConnectionString;
            this.dbName = new DBName();
            this.sqlcon = new SqlConnectionFactory(strConnectionString);
            this._user = new User();
            this._userInfo = new UserInfos();
            this.dbManager = new DbManager(this._userInfo, this._user, this.sqlcon);
            this.mUser = new MUser();
            this._vmNewPassword = new NewPassordViewModel();
            this.VmLogin = new LoginViewModel(this.navigationStore, this.mUser, this._vmUserReset, this._mStudent, this.dbManager, this.dbName);
            this._mStudent = new MStudentInformations();
            this._vmRegister = new RegisterViewModel(this.VmLogin, this.mUser, this.dbManager);
            this._vmUserReset = new UserResetViewModel(this._vmNewPassword,this.dbManager,this.dbName, this.mUser);
            this.navigationStore = new NavigationStore();
            this.mainWindow = new MainWindow();
            this._NavigationBar = new NavigationBarViewModel("Home");
            this.ServerView = new SQLServerView(this._vmRegister,this._vmUserReset,this._mStudent,this.mUser,this.dbManager,this.dbName);
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
            INavigateService<HomeViewModel> homeNavigationService = new LayoutNavigationService<HomeViewModel>(this.navigationStore,
                        () => new HomeViewModel(this.navigationStore, this._vmRegister, this._vmUserReset,this._mStudent,this.mUser,this.dbManager,this.dbName), this._NavigationBar);
            homeNavigationService.Navigate();
            this.mainWindow.DataContext = new mainViewModel(this.navigationStore, this._vmRegister,this._vmUserReset,this._mStudent,this.mUser,this.dbManager,this.dbName);
            this.mainWindow.Show();
        }
        
    }
}
