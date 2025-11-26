using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using EngineeringToolsCV_1.IRepository;
using EngineeringToolsCV_1.Models;



namespace EngineeringToolsCV_1.DatabaseManager
{
    public class DbManager
    {
        private IUserInfo _iUserInfo;
        private IUser _iUser;
        private IConnectionFactory _IConn;

        public DbManager(IUserInfo iUserInfo, IUser iUser, IConnectionFactory iConn)
        {
            this._iUserInfo = iUserInfo;
            this._iUser = iUser;
            this._IConn = iConn;
        }

        public int SetAllInfos(string strQuery)
        {
            return this._iUserInfo.SaveStudentInfos(strQuery, this._IConn.Create());
        }

        public DataTable SetLoginUser(MUser mUser,string strQuery)
        {         
            return this._iUser.LoginUser(mUser, this._IConn.Create(), strQuery);
        }

        public void registerUser(string strQuery, MUser mUser)
        {
           this._iUser.AddUser(mUser, this._IConn.Create(), strQuery);
        }

        public string GetEmail(MUser mUser, string strQueryRegister)
        {
            return this._iUser.GetUserEmail(mUser, this._IConn.Create(), strQueryRegister);
        }
    }
}
