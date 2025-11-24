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
            this.sqlconManager.ConnectionString = connectionString;
            //Sql-command Objekt instanzieren.
            this.sqlcmdManager = new SqlCommand();
            this.sqlcmdManager.Connection = sqlconManager;

            try
            {
                //Verbindung öffnen.
                this.sqlconManager.Open();
                strQueryRegister = string.Format("INSERT INTO {0} ({1},{2},{3}) VALUES(@1,@2,@3)",
                                                  this.constante.StrTBL_User,
                                                  this.constante.StrId,
                                                  this.constante.StrEmail,
                                                  this.constante.StrPasswort);

                //Parameters-collection leeren.
                this.sqlcmdManager.Parameters.Clear();
                // Parameters collection einfügen.
                this.sqlcmdManager.Parameters.AddWithValue("@1", mUser.Id);
                this.sqlcmdManager.Parameters.AddWithValue("@2", mUser.Email);
                this.sqlcmdManager.Parameters.AddWithValue("@3", mUser.Passwort);

                //Sql-Abfrage festlegen.
                this.sqlcmdManager.CommandType = CommandType.Text;
                this.sqlcmdManager.CommandText = strQueryRegister;
                // Bestätigung der Passwort.
                if (mUser.Passwort == mUser.ConfirmPasswort)
                {
                    //sql-Befehle ausführen.
                    iCount = this.sqlcmdManager.ExecuteNonQuery();
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
                this.sqlconManager.Close();
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
            this.sqlconManager = new SqlConnection();
            //Sql-command Objekt instanzieren.
            this.sqlcmdManager = new SqlCommand();
            this.constante = new DBName();
            //Tabelle erzeugen.
            this.dtDatatable = new DataTable();
            //Sql-Command zuweisen.
            this.sqlcmdManager.Connection = this.sqlconManager;
            this.sqladDataAdapter = new SqlDataAdapter(this.sqlcmdManager);
            this.connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            //Die Verbindung einer Datenbank festlegen.
            this.sqlconManager.ConnectionString = this.ConnectionString;

            try
            {
                //Verbindung öffnen.
                sqlconManager.Open();
                //sql-Befehle zusammensetzen.
                strQueryLogin = String.Format("SELECT {1} FROM {0} WHERE {1}=@1 AND {2}=@2",
                                               this.constante.StrTBL_User,
                                               this.constante.StrEmail);

                //Parameters-collection leeren.
                this.sqlcmdManager.Parameters.Clear();
                //Parameters collection einfügen.
                this.sqlcmdManager.Parameters.AddWithValue("@1", mUser.Id);
                this.sqlcmdManager.Parameters.AddWithValue("@2", mUser.Passwort);
                //Sql-Abfrage festlegen.
                this.sqlcmdManager.CommandType = CommandType.Text;
                this.sqlcmdManager.CommandText = strQueryLogin;

                //Tabelle einer Datenbank füllen.
                this.sqladDataAdapter.Fill(this.dtDatatable);
                //Objekt freigegen.
                this.sqlcmdManager.Dispose();
                this.sqlconManager.Dispose();
                this.sqladDataAdapter.Dispose();
                //Die Verbindung schließen.
                this.sqlconManager.Close();
            }
            catch (Exception ex)
            {
                //Fehlermeldung
                this.dialogMessage.ErrorMessage.Text = ex.Message.ToString();
            }

            return this.dtDatatable.Rows.ToString();
        }

        public DataTable LoginUser(MUser mUser)
        {
            String strQueryLogin;        
            this.dialogMessage = new MessageDialog();
            //Connectionstring-Objekt instanzieren.
            this.sqlconManager = new SqlConnection();
            //Sql-command Objekt instanzieren.
            this.sqlcmdManager = new SqlCommand();
            this.constante = new DBName();
            //Tabelle erzeugen.
            this.dtDatatable = new DataTable();
            //Sql-Command zuweisen.
            this.sqlcmdManager.Connection = sqlconManager;
            this.sqladDataAdapter = new SqlDataAdapter(sqlcmdManager);
            this.connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            //Die Verbindung einer Datenbank festlegen.
            this.sqlconManager.ConnectionString = connectionString;

            try
            {
                //Verbindung öffnen.
                this.sqlconManager.Open();
                //sql-Befehle zusammensetzen.
                strQueryLogin = String.Format("SELECT {1},{2} FROM {0} WHERE {1}=@1 AND {2}=@2",
                                               this.constante.StrTBL_User,
                                               this.constante.StrId,
                                               this.constante.StrPasswort);

                //Parameters-collection leeren.
                this.sqlcmdManager.Parameters.Clear();
                //Parameters collection einfügen.
                this.sqlcmdManager.Parameters.AddWithValue("@1", mUser.Id);
                this.sqlcmdManager.Parameters.AddWithValue("@2", mUser.Passwort);
                //Sql-Abfrage festlegen.
                this.sqlcmdManager.CommandType = CommandType.Text;
                this.sqlcmdManager.CommandText = strQueryLogin;

                //Tabelle einer Datenbank füllen.
                this.sqladDataAdapter.Fill(dtDatatable);
                //Objekt freigegen.
                this.sqlcmdManager.Dispose();
                this.sqlconManager.Dispose();
                this.sqladDataAdapter.Dispose();
                //Die Verbindung schließen.
                this.sqlconManager.Close();
            }
            catch (Exception ex)
            {
                //Fehlermeldung
                this.dialogMessage.ErrorMessage.Text = ex.Message.ToString();
            }

            return this.dtDatatable;
        }

        public void UpdateUser(MUser mUser)
        {
            throw new NotImplementedException();
        }
    }
}
