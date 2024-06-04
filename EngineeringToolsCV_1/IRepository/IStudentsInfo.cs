using System;
using System.Collections.Generic;
using System.Windows.Controls;
using System.Text;
using System.Windows.Media;

namespace EngineeringToolsCV_1.Models
{
    public interface IStudentsInfo
    {
        public void UpdateStudentInfos(MStudentInformations mStudentInformations);
        public int SaveStudentInfos( string strQuery);
        public void FindStudentInfos(MStudentInformations mStudentInformations);
        public void AddStudentInfos(MStudentInformations mStudentInformations);
        public void RemoveStudentInfos(MStudentInformations mStudentInformations);
        public ImageSource Foto();
        public Byte[] ConvertImageToByte(Image img);
    }
}
