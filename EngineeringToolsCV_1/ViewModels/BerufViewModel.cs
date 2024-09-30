using EngineeringToolsCV_1.Command;
using EngineeringToolsCV_1.Models;
using EngineeringToolsCV_1.Store;
using EngineeringToolsCV_1.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace EngineeringToolsCV_1.ViewModels
{
    public class BerufViewModel : ViewModelBase
    {
        private NavigationStore navigationStore;
        private NavigationBarViewModel navigationBar;
        private MStudentInformations _mStudentInfos;
        public ICommand NavigateReturnCommand { get; set; }

        public BerufViewModel(NavigationStore navigationStore, MStudentInformations mStudentInfos)
        {
            this.navigationStore = navigationStore;
            this._mStudentInfos = mStudentInfos;
            navigationBar = new NavigationBarViewModel("Home -> Dashboard");
            this.NavigateReturnCommand = new NavigateCommand<DashboardViewModel>(
               new LayoutNavigationService<DashboardViewModel>(navigationStore,
               () => new DashboardViewModel(navigationStore, this._mStudentInfos), navigationBar));
        }
    }
}
