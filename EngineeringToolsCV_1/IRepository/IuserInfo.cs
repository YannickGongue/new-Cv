using System;
using System.Collections.Generic;
using System.Windows.Controls;
using System.Text;
using System.Windows.Media;
using System.Data.SqlClient;

namespace EngineeringToolsCV_1.Models
{
    public interface IUserInfo
    {
        public void UpdateStudentInfos(MStudentInformations mStudentInformations);
        public int SaveStudentInfos( string strQuery, SqlConnection sqlcon);
        public void FindStudentInfos(MStudentInformations mStudentInformations);
        public void AddStudentInfos(MStudentInformations mStudentInformations, SqlConnection sqlCon, string strQueryRegister);
        public void RemoveStudentInfos(MStudentInformations mStudentInformations);
        //public ImageSource Foto();
        //public Byte[] ConvertImageToByte(Image img);
    }
}
