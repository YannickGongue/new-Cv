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
using System.Threading.Tasks;

namespace EngineeringToolsCV_1.Repositories
{
    public class UserInfos : IUserInfo
    {
        private SqlCommand sqlcmdManager;
        private SqlDataAdapter sqladDataAdapter;
        private DataTable dtDatatable;

        public void AddStudentInfos(SqlConnection sqlCon, string strQueryRegister)
        {
            throw new NotImplementedException();
        }


        public DataTable GetUserData(SqlConnection sqlcon, string strQueryLogin)
        {
            //Tabelle erzeugen.
            this.dtDatatable = new DataTable();
            
            //Sql-Command zuweisen.
            this.sqlcmdManager = new SqlCommand(strQueryLogin, sqlcon);
            this.sqladDataAdapter = new SqlDataAdapter(sqlcmdManager);
            //Verbindung öffnen.
            sqlcon.Open();

            //Sql-Abfrage festlegen.
            this.sqlcmdManager.CommandType = CommandType.Text;
            this.sqlcmdManager.CommandText = strQueryLogin;

            //Tabelle einer Datenbank füllen.
            this.sqladDataAdapter.Fill(dtDatatable);

            //Die Verbindung schließen.
            sqlcon.Close();
            sqlcon.Dispose();
            //Objekt freigegen.
            this.sqlcmdManager.Dispose();
            this.sqladDataAdapter.Dispose();
            
            return this.dtDatatable;
        }


        public void RemoveStudentInfos(MStudentInformations mStudentInformations)
        {
            throw new NotImplementedException();
        }

        public int SaveData(string strQueryRegister, SqlConnection sqlcon)
        {
            int iCount;                              
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
