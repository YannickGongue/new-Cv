using EngineeringToolsCV_1.Models;
using EngineeringToolsCV_1.Style;
using EngineeringToolsCV_1.Views;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Controls;
using System.IO;
using System.Text;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace EngineeringToolsCV_1.Repositories
{
    public class UserInfos : IUserInfo
    {
        private SqlCommand sqlcmdManager;         
        private SqlConnection sqlconManager;      
       
        private string connectionString;
        private MessageDialog dialogMessage;

        public void AddStudentInfos(MStudentInformations mStudentInformations)
        {
            throw new NotImplementedException();
        }
       

        public void FindStudentInfos(MStudentInformations mStudentInformations)
        {
            throw new NotImplementedException();
        }

        
        public void RemoveStudentInfos(MStudentInformations mStudentInformations)
        {
            throw new NotImplementedException();
        }

        public int SaveStudentInfos(string strQueryRegister)
        {
            int iCount;                              
            this.dialogMessage = new MessageDialog();

            //Connectionstring-Objekt instanzieren.
            sqlconManager = new SqlConnection();

            this.connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            //Die Verbindung einer Datenbank festlegen.
            sqlconManager.ConnectionString = connectionString;
            //Sql-command Objekt instanzieren.
            sqlcmdManager = new SqlCommand();
          
            //Sql-Command zuweisen.
            sqlcmdManager.Connection = sqlconManager;
               
             //Verbindung öffnen.
             sqlconManager.Open();               

            //Sql-Abfrage festlegen.
            sqlcmdManager.CommandType = CommandType.Text;
            sqlcmdManager.CommandText = strQueryRegister;
                    
            //sql-Befehle ausführen.
            iCount = sqlcmdManager.ExecuteNonQuery();
               
            //Die Verbindung schließen.
            sqlconManager.Close();

            return iCount;
          
        }

        public void UpdateStudentInfos(MStudentInformations mStudentInformations)
        {
            throw new NotImplementedException();
        }
    }
}
