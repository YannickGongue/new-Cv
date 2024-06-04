using EngineeringToolsCV_1.Command;
using EngineeringToolsCV_1.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using System.Windows.Media;

namespace EngineeringToolsCV_1.ViewModels
{
    public class UserResetViewModel : ViewModelBase
    {
        private NewPassword newPassword;
        private string setEmail;
        private bool setIsEnabled;
        private Brush setBackground;

        public Brush SetBackground
        {
            get
            {
                return this.setBackground;
            }
            set
            {
                this.setBackground = value;
                this.OnPropertyChanged(nameof(this.SetBackground));
            }
        }

        public bool SetIsEnabled
        {
            get
            {
                return this.setIsEnabled;
            }
            set
            {
                this.setIsEnabled = value;
                this.OnPropertyChanged(nameof(this.SetIsEnabled));
            }
        }

        public string SetEmail
        {
            get
            {
                return this.setEmail;
            }
            set
            {
                this.setEmail = value;
                this.OnPropertyChanged(nameof(this.SetEmail));
            }
        }

        public ICommand OnSearchCommand { get; }

        public UserResetViewModel()
        {
            this.SetBackground = Brushes.RoyalBlue;
            this.setIsEnabled = true;
            OnSearchCommand = new DelegateCommand(ExecuteSearchEmail, CanExecute);
        }

        private bool CanExecute(object obj)
        {
            return true;
        }

        private void ExecuteSearchEmail(object obj)
        {
            this.SetBackground = Brushes.AliceBlue;
            this.SetIsEnabled = false;
            this.newPassword = new NewPassword(this);
            this.newPassword.Show();
            
        }
    }
}
