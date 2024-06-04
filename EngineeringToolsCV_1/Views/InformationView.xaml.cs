using EngineeringToolsCV_1.Models;
using EngineeringToolsCV_1.Repositories;
using EngineeringToolsCV_1.ViewModels;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace EngineeringToolsCV_1.Views
{
    /// <summary>
    /// Interaktionslogik für PageInformation.xaml
    /// </summary>
    public partial class InformationView : UserControl
    {
        private UserInfos userInfosRepositories;
        private MStudentInformations mStudentInformations;
        private MessageDialog dialogMessage;
        //private InformationViewModel informationViewModel;

        public InformationView()
        {
            InitializeComponent();
            
        }


        private void LoadFotoButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                this.imageFoto.Source = this.userInfosRepositories.Foto();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
