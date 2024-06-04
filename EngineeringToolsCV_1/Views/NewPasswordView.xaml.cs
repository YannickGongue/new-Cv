using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using EngineeringToolsCV_1.ViewModels;

namespace EngineeringToolsCV_1.Views
{
    /// <summary>
    /// Interaktionslogik für NewPassword.xaml
    /// </summary>
    public partial class NewPassword : Window
    {
        private UserResetViewModel _vmUserReset;
        public NewPassword(UserResetViewModel vmUserReset)
        {
            this._vmUserReset = vmUserReset;
            InitializeComponent();
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            this._vmUserReset.SetIsEnabled = true;
            this._vmUserReset.SetBackground = Brushes.RoyalBlue;                                                                                                                                                                                                           
        }

        private void MinimizeButton_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void MaximizeButton_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Maximized;
        }
    }
}
