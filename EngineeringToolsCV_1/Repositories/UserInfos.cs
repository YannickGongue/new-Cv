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
using EngineeringToolsCV_1.IRepository;
using EngineeringToolsCV_1.DatabaseManager;

namespace EngineeringToolsCV_1.Repositories
{
    public class UserInfos : IUserInfo
    {
        private DBName _dbName;
        private readonly IConnectionFactory _connectionFactory;

        public UserInfos(IConnectionFactory connectionFactory, DBName dbName)
        {
            this._connectionFactory = connectionFactory;
            this._dbName = dbName;
        }

  
        public async Task<int> RemoveStudentInfosAsync(string studentId)
        {
            using var conn = _connectionFactory.Create();
            using var cmd = new SqlCommand(@"
                DELETE FROM TBLStudentsDaten 
                WHERE Id = @Id
            ", conn);

            cmd.Parameters.AddWithValue("@Id", studentId);

            await conn.OpenAsync();
            return await cmd.ExecuteNonQueryAsync();
        }

        public async Task<DataTable> GetUserInfoAsync(string id, string password)
        {

            string strQueryLogin = String.Format("SELECT * FROM {0} WHERE {1}= @1 AND {2}= @2",
                                                this._dbName.StrTBL_User,
                                                this._dbName.StrId,
                                                this._dbName.StrPasswort);

            using var conn = _connectionFactory.Create();
            using var cmd = new SqlCommand(strQueryLogin, conn);

            cmd.Parameters.AddWithValue("@1", id);
            cmd.Parameters.AddWithValue("@2", password);

            await conn.OpenAsync();

            var dt = new DataTable();
            using var adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);

            return dt;
        }

        public async Task<int> AddStudentInfosAsync(MStudentInformations info)
        {
            string strQueryRegister = string.Format("INSERT INTO {0} ({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12})" +
                                                    "VALUES(@1,@2,@3,@4,@5,@6,@7,@8,@9,@10,@11.@12)",
                                                    this._dbName.strTBL_StudentsInfo, this._dbName.StrId,
                                                    this._dbName.strName,
                                                    this._dbName.strVorname, this._dbName.StrEmail,
                                                    this._dbName.strStraße, this._dbName.strNummer,
                                                    this._dbName.strPostleitzahl, this._dbName.strStadt,
                                                    this._dbName.strDatum, this._dbName.strLand,
                                                    this._dbName.strImageData, this._dbName.strFileName);

            using var conn = _connectionFactory.Create();
            using var cmd = new SqlCommand( strQueryRegister, conn);

            cmd.Parameters.AddWithValue("@1", info.Id);
            cmd.Parameters.AddWithValue("@2", info.Name);
            cmd.Parameters.AddWithValue("@3", info.Vorname);
            cmd.Parameters.AddWithValue("@4", info.Email);
            cmd.Parameters.AddWithValue("@5", info.Straße);
            cmd.Parameters.AddWithValue("@6", info.Straßenummer);
            cmd.Parameters.AddWithValue("@7", info.Postleitzahl);
            cmd.Parameters.AddWithValue("@8", info.Stadt);
            cmd.Parameters.AddWithValue("@9", info.Datum);
            cmd.Parameters.AddWithValue("@10", info.Land);
            cmd.Parameters.AddWithValue("@11", info.img);
            cmd.Parameters.AddWithValue("@12", info.FileName);

            await conn.OpenAsync();
            return await cmd.ExecuteNonQueryAsync();
        }

        public async Task< DataTable> SearchStudentInfosAsync(string search)
        {
            var dt = new DataTable();
            string strQuery = String.Format("SELECT {1},{2},{3},{4},{5},{6},{7},{8},{9} FROM {0} WHERE {10}= '{11}'",
                                             this._dbName.strTBL_StudentsInfo, this._dbName.strName,
                                             this._dbName.strVorname, this._dbName.StrEmail,
                                             this._dbName.strStraße, this._dbName.strNummer,
                                             this._dbName.strPostleitzahl, this._dbName.strStadt,
                                             this._dbName.strDatum, this._dbName.strLand, this._dbName.StrId,
                                             search);

         
            using var conn = _connectionFactory.Create();
            using var cmd = new SqlCommand(strQuery, conn);
            var adapter = new SqlDataAdapter(cmd);
            
             await conn.OpenAsync();
             adapter.Fill(dt);
                     
            return dt;
        }

        public async Task<int> UpdateUserInfosAsync(MUser info)
        {
            string strQueryRegister = string.Format("UPDATE {0} SET {1}= @1, {2}=@2 WHERE {3} = @3 ",
                                                     this._dbName.StrTBL_User,                                                     
                                                     this._dbName.StrEmail,
                                                     this._dbName.StrPasswort,
                                                     this._dbName.StrId);

            using var conn = _connectionFactory.Create();
            using var cmd = new SqlCommand(strQueryRegister, conn);

            cmd.Parameters.AddWithValue("@1", info.Email);
            cmd.Parameters.AddWithValue("@2", info.Passwort);
            cmd.Parameters.AddWithValue("@3", info.Id);
            
            await conn.OpenAsync();
            return await cmd.ExecuteNonQueryAsync();
        }
    }
}
