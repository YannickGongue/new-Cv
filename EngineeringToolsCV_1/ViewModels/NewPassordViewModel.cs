using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace EngineeringToolsCV_1.ViewModels
{
    public class NewPassordViewModel : INotifyPropertyChanged
    {
        private bool setActveWindow;

        public bool SetActivedWindow
        {

            get { return this.setActveWindow; }
            set
            {
                if (this.setActveWindow != value)
                {
                    this.setActveWindow = value;
                    this.OnPropertyChanged(new PropertyChangedEventArgs(nameof(SetActivedWindow)));
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(PropertyChangedEventArgs e)
        {
            if (PropertyChanged != null)
                PropertyChanged.Invoke(this, e);
        }
    }
}
