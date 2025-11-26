using EngineeringToolsCV_1.Models;
using EngineeringToolsCV_1.Views;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace EngineeringToolsCV_1.IRepository
{
    public interface IUser
    {
        public DataTable LoginUser(MUser mUser, SqlConnection sqlCon, string strQueryRegister);
        public void UpdateUser(MUser mUser);
        public void AddUser(MUser mUser, SqlConnection sqlCon, string strQueryRegister);
        public void FindUser(MUser mUser);
        public string GetUserEmail(MUser mUser, SqlConnection sqlCon, string strQueryRegister);

    }
}
