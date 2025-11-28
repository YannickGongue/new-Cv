using EngineeringToolsCV_1.DatabaseManager;
using EngineeringToolsCV_1.IRepository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace EngineeringToolsCV_1.Repositories
{
     public class User : IUser
     {
        private DBName _dbName;
        private readonly IConnectionFactory _connectionFactory;

        public User(IConnectionFactory connectionFactory, DBName dbName)
        {
            this._connectionFactory = connectionFactory;
            this._dbName = dbName;
        }

        public async Task<DataTable> GetUserDataAsync(string id, string password, string email, int Flag)
        {
            string strQueryLogin;

            if (Flag == 1)
            {
                strQueryLogin = String.Format("SELECT * FROM {0} WHERE {1}= @1 AND {2}= @2",
                                                this._dbName.StrTBL_User,
                                                this._dbName.StrId,
                                                this._dbName.StrPasswort);

                using var conn = _connectionFactory.Create();
                using var cmd = new SqlCommand(strQueryLogin, conn);

                cmd.Parameters.AddWithValue("@1", id);
                cmd.Parameters.AddWithValue("@2", password);
            }
            else
            {
                strQueryLogin = String.Format("SELECT {1} FROM {0} WHERE {2}= @1",
                                                this._dbName.StrTBL_User,
                                                this._dbName.StrEmail,
                                                this._dbName.StrId );

                using var conn = _connectionFactory.Create();
                using var cmd = new SqlCommand(strQueryLogin, conn);

                cmd.Parameters.AddWithValue("@1", id);
            }
           

            

            await conn.OpenAsync();

            var dt = new DataTable();
            using var adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);

            return dt;
        }
    }
}
