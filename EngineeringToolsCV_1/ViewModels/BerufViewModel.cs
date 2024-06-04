using EngineeringToolsCV_1.Store;
using System;
using System.Collections.Generic;
using System.Text;

namespace EngineeringToolsCV_1.ViewModels
{
    public class BerufViewModel : ViewModelBase
    {
        private NavigationStore navigationStore;

        public BerufViewModel(NavigationStore navigationStore)
        {
            this.navigationStore = navigationStore;
        }
    }
}
