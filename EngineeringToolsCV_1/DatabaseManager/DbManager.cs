using System;
using System.Collections.Generic;
using System.Text;
using EngineeringToolsCV_1.IRepository;
using EngineeringToolsCV_1.Models;


namespace EngineeringToolsCV_1.DatabaseManager
{
    public class DbManager
    {
        private IUserInfo _iUser;

        public DbManager(IUserInfo iUser)
        {
            this._iUser = iUser;
        }

        public int SetAllInfos(string strQuery)
        {
            return this._iUser.SaveStudentInfos(strQuery);

        }
    }
}
