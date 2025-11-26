using EngineeringToolsCV_1.IRepository;
using EngineeringToolsCV_1.Models;
using EngineeringToolsCV_1.ViewModels;
using EngineeringToolsCV_1.Views;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using EngineeringToolsCV_1.DatabaseManager;

namespace EngineeringToolsCV_1.Repositories
{
    public class User : IUser
    {
        //private RegisterViewModel registerModelView;
        private ErrorMessageViewModel ErrorMessageView;
        private MessageDialog dialogMessage;
        private DataTable dtDatatable;               
        private SqlDataAdapter sqladDataAdapter;
        private SqlCommand sqlcmdManager;         
        

        public void AddUser(MUser mUser, SqlConnection sqlcon, string strQueryRegister)
        {
            int iCount;                   
            //this.registerModelView = new RegisterViewModel();
            this.ErrorMessageView = new ErrorMessageViewModel();
            this.dialogMessage = new MessageDialog();
            //Sql-command Objekt instanzieren.
            this.sqlcmdManager = new SqlCommand(strQueryRegister, sqlcon);

            try
            {
                //Verbindung öffnen.
                sqlcon.Open();
                
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
                sqlcon.Close();
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

        public string GetUserEmail(MUser mUser, SqlConnection sqlcon, string strQueryRegister)
        {
            this.dialogMessage = new MessageDialog();
            
            //Tabelle erzeugen.
            this.dtDatatable = new DataTable();
           

            try
            {
                //Sql-Command zuweisen.
                this.sqlcmdManager = new SqlCommand(strQueryRegister, sqlcon);
                this.sqladDataAdapter = new SqlDataAdapter(this.sqlcmdManager);
                //Verbindung öffnen.
                sqlcon.Open();
                
                //Sql-Abfrage festlegen.
                this.sqlcmdManager.CommandType = CommandType.Text;
                this.sqlcmdManager.CommandText = strQueryRegister;

                //Tabelle einer Datenbank füllen.
                this.sqladDataAdapter.Fill(this.dtDatatable);
                //Objekt freigegen.
                this.sqlcmdManager.Dispose();
                sqlcon.Dispose();
                this.sqladDataAdapter.Dispose();
                //Die Verbindung schließen.
                sqlcon.Close();
            }
            catch (Exception ex)
            {
                //Fehlermeldung
                this.dialogMessage.ErrorMessage.Text = ex.Message.ToString();
            }

            return this.dtDatatable.Rows[0][0].ToString();
        }

        public DataTable LoginUser(MUser mUser, SqlConnection sqlcon, string strQueryLogin)
        {
            this.dialogMessage = new MessageDialog();
            //Tabelle erzeugen.
            this.dtDatatable = new DataTable();        

            try
            {
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
