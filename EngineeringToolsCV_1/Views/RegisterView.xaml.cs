﻿using System;
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
using System.Data.SqlClient;
using EngineeringToolsCV_1.Repositories;
using EngineeringToolsCV_1.Models;
using EngineeringToolsCV_1.ViewModels;

namespace EngineeringToolsCV_1.Views
{
    /// <summary>
    /// Interaktionslogik für UserRegister.xaml
    /// </summary>
    public partial class RegisterView : Window
    {
        private User userRepositories;
        private LoginViewModel _vmLogin;
        private MUser mUser;
        
        public RegisterView(LoginViewModel vmLogin)
        {
            this._vmLogin = vmLogin;
            InitializeComponent();
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            this._vmLogin.SetActivedWindow = true;
        }

        private void MinimizeButton_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void MaximizeButton_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Maximized;
        }

        private void RegisterButton_Click(object sender, RoutedEventArgs e)
        {
            this.userRepositories = new User();            
            this.mUser = new MUser();

            this.mUser.Id = this.Username.Text;
            this.mUser.Email = this.Email.Text;
            this.mUser.Passwort = this.Password.Text;
            this.mUser.ConfirmPasswort = this.ConfirmPasswort.Text;

            this.userRepositories.AddUser(mUser);
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
