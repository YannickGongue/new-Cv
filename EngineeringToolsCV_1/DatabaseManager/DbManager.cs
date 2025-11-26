using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using EngineeringToolsCV_1.IRepository;
using EngineeringToolsCV_1.Models;



namespace EngineeringToolsCV_1.DatabaseManager
{
    public class DbManager
    {
        private IUserInfo _iUserInfo;
        private IConnectionFactory _IConn;

        public DbManager(IUserInfo iUserInfo, IConnectionFactory iConn)
        {
            this._iUserInfo = iUserInfo;
            this._IConn = iConn;
        }

        public int SetDataToDB(string strQuery)
        {
            return this._iUserInfo.SaveData(strQuery, this._IConn.Create());
        }

        public DataTable GetUserDataFromDB(string strQuery)
        {         
            return this._iUserInfo.GetUserData(this._IConn.Create(), strQuery);
        }     
        
    }
}
