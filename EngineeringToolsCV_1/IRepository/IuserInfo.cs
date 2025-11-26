using System;
using System.Collections.Generic;
using System.Windows.Controls;
using System.Text;
using System.Windows.Media;
using System.Data.SqlClient;
using System.Data;
using System.Threading.Tasks;

namespace EngineeringToolsCV_1.Models
{
    public interface IUserInfo
    {
        public void UpdateStudentInfos(MStudentInformations mStudentInformations);
        public int SaveData( string strQuery, SqlConnection sqlcon);
        public DataTable GetUserData(SqlConnection sqlcon, string strQueryLogin);   
        public void AddStudentInfos( SqlConnection sqlCon, string strQueryRegister);
        public void RemoveStudentInfos(MStudentInformations mStudentInformations);
        //public ImageSource Foto();
        //public Byte[] ConvertImageToByte(Image img);
    }
}
