using EngineeringToolsCV_1.Models;
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
       
        private string connectionString;
        private MessageDialog dialogMessage;

        public void AddStudentInfos(MStudentInformations mStudentInformations, SqlConnection sqlCon, string strQueryRegister)
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

        public int SaveStudentInfos(string strQueryRegister, SqlConnection sqlcon)
        {
            int iCount;                              
            this.dialogMessage = new MessageDialog();
            //Sql-command Objekt instanzieren.
            sqlcmdManager = new SqlCommand(strQueryRegister, sqlcon);
                       
             //Verbindung öffnen.
            sqlcon.Open();               

            //Sql-Abfrage festlegen.
            this.sqlcmdManager.CommandType = CommandType.Text;
            this.sqlcmdManager.CommandText = strQueryRegister;
                    
            //sql-Befehle ausführen.
            iCount = sqlcmdManager.ExecuteNonQuery();
               
            //Die Verbindung schließen.
            sqlcon.Close();

            return iCount;
          
        }

        public void UpdateStudentInfos(MStudentInformations mStudentInformations)
        {
            throw new NotImplementedException();
        }
    }
}
