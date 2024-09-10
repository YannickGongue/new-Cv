using EngineeringToolsCV_1.IRepository;
using EngineeringToolsCV_1.Models;
using EngineeringToolsCV_1.Style;
using EngineeringToolsCV_1.ViewModels;
using EngineeringToolsCV_1.Views;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace EngineeringToolsCV_1.Repositories
{
    public class User : Setting, IUser
    {
        //private RegisterViewModel registerModelView;
        private ErrorMessageViewModel ErrorMessageView;
        private MessageDialog dialogMessage;
        private DBName constante; 
        private DataTable dtDatatable;               
        private SqlDataAdapter sqladDataAdapter;
        private string connectionString;
        private SqlCommand sqlcmdManager;         
        private SqlConnection sqlconManager;    
        

        public void AddUser(MUser mUser)
        {
            int iCount;                   
            string strQueryRegister;
            //this.registerModelView = new RegisterViewModel();
            this.ErrorMessageView = new ErrorMessageViewModel();
            this.dialogMessage = new MessageDialog();
            this.sqlconManager = new SqlConnection();
            this.constante = new DBName();
            this.connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            //Die Verbindung einer Datenbank festlegen.
            this.sqlconManager.ConnectionString = ConnectionString;
            //Sql-command Objekt instanzieren.
            this.sqlcmdManager = new SqlCommand();
            this.sqlcmdManager.Connection = sqlconManager;

            try
            {
                //Verbindung öffnen.
                sqlconManager.Open();
                strQueryRegister = string.Format("INSERT INTO {0} ({1},{2},{3}) VALUES(@1,@2,@3)",
                                                  constante.StrTBL_User,
                                                  constante.StrId,
                                                  constante.StrEmail,
                                                  constante.StrPasswort);

                //Parameters-collection leeren.
                sqlcmdManager.Parameters.Clear();
                // Parameters collection einfügen.
                sqlcmdManager.Parameters.AddWithValue("@1", mUser.Id);
                sqlcmdManager.Parameters.AddWithValue("@2", mUser.Email);
                sqlcmdManager.Parameters.AddWithValue("@3", mUser.Passwort);
                
                //Sql-Abfrage festlegen.
                sqlcmdManager.CommandType = CommandType.Text;
                sqlcmdManager.CommandText = strQueryRegister;
                // Bestätigung der Passwort.
                if (mUser.Passwort == mUser.ConfirmPasswort)
                {
                    //sql-Befehle ausführen.
                    iCount = sqlcmdManager.ExecuteNonQuery();
                    //sind die Datensätze eingefügt?
                    if (iCount == 1)
                    {
                        this.dialogMessage.ErrorMessage.Text = "die Einträgen wurden erfolgreich in die Datenbank hinzugefügt";
                        this.dialogMessage.Show();
                    }              
                }
                else
                {
                    this.dialogMessage.ErrorMessage.Text = "Die Passwort stimmen nicht überein";
                    this.dialogMessage.Show();
                }
                //Die Verbindung schließen.
                sqlconManager.Close();
            }
            catch (Exception ex)
            {
                //Fehlermeldung
                this.dialogMessage.ErrorMessage.Text = ex.Message.ToString();
                this.dialogMessage.Show();
            }
        }
    

        public void FindUser(MUser mUser)
        {
            throw new NotImplementedException();
        }

        public string GetUserEmail(MUser mUser)
        {
            String strQueryLogin;
            this.dialogMessage = new MessageDialog();
            //Connectionstring-Objekt instanzieren.
            sqlconManager = new SqlConnection();
            //Sql-command Objekt instanzieren.
            sqlcmdManager = new SqlCommand();
            constante = new DBName();
            //Tabelle erzeugen.
            dtDatatable = new DataTable();
            //Sql-Command zuweisen.
            sqlcmdManager.Connection = sqlconManager;
            sqladDataAdapter = new SqlDataAdapter(sqlcmdManager);
            this.connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            //Die Verbindung einer Datenbank festlegen.
            sqlconManager.ConnectionString = ConnectionString;

            try
            {
                //Verbindung öffnen.
                sqlconManager.Open();
                //sql-Befehle zusammensetzen.
                strQueryLogin = String.Format("SELECT {1} FROM {0} WHERE {1}=@1 AND {2}=@2",
                                               constante.StrTBL_User,
                                               constante.StrEmail);

                //Parameters-collection leeren.
                sqlcmdManager.Parameters.Clear();
                //Parameters collection einfügen.
                sqlcmdManager.Parameters.AddWithValue("@1", mUser.Id);
                sqlcmdManager.Parameters.AddWithValue("@2", mUser.Passwort);
                //Sql-Abfrage festlegen.
                sqlcmdManager.CommandType = CommandType.Text;
                sqlcmdManager.CommandText = strQueryLogin;

                //Tabelle einer Datenbank füllen.
                sqladDataAdapter.Fill(dtDatatable);
                //Objekt freigegen.
                sqlcmdManager.Dispose();
                sqlconManager.Dispose();
                sqladDataAdapter.Dispose();
                //Die Verbindung schließen.
                sqlconManager.Close();
            }
            catch (Exception ex)
            {
                //Fehlermeldung
                this.dialogMessage.ErrorMessage.Text = ex.Message.ToString();
            }

            return dtDatatable.Rows.ToString();
        }

        public DataTable LoginUser(MUser mUser)
        {
            String strQueryLogin;        
            this.dialogMessage = new MessageDialog();
            //Connectionstring-Objekt instanzieren.
            sqlconManager = new SqlConnection();
            //Sql-command Objekt instanzieren.
            sqlcmdManager = new SqlCommand();
            constante = new DBName();
            //Tabelle erzeugen.
            dtDatatable = new DataTable();
            //Sql-Command zuweisen.
            sqlcmdManager.Connection = sqlconManager;
            sqladDataAdapter = new SqlDataAdapter(sqlcmdManager);
            this.connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            //Die Verbindung einer Datenbank festlegen.
            sqlconManager.ConnectionString = ConnectionString;

            try
            {
                //Verbindung öffnen.
                sqlconManager.Open();
                //sql-Befehle zusammensetzen.
                strQueryLogin = String.Format("SELECT {1},{2} FROM {0} WHERE {1}=@1 AND {2}=@2",
                                               constante.StrTBL_User,
                                               constante.StrId,
                                               constante.StrPasswort);

                //Parameters-collection leeren.
                sqlcmdManager.Parameters.Clear();
                //Parameters collection einfügen.
                sqlcmdManager.Parameters.AddWithValue("@1", mUser.Id);
                sqlcmdManager.Parameters.AddWithValue("@2", mUser.Passwort);
                //Sql-Abfrage festlegen.
                sqlcmdManager.CommandType = CommandType.Text;
                sqlcmdManager.CommandText = strQueryLogin;

                //Tabelle einer Datenbank füllen.
                sqladDataAdapter.Fill(dtDatatable);
                //Objekt freigegen.
                sqlcmdManager.Dispose();
                sqlconManager.Dispose();
                sqladDataAdapter.Dispose();
                //Die Verbindung schließen.
                sqlconManager.Close();
            }
            catch (Exception ex)
            {
                //Fehlermeldung
                this.dialogMessage.ErrorMessage.Text = ex.Message.ToString();
            }

            return dtDatatable;
        }

        public void UpdateUser(MUser mUser)
        {
            throw new NotImplementedException();
        }
    }
}
