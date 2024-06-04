using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace EngineeringToolsCV_1.Models
{
    public class MStudentInformations
    {
        public string Name { get; set; }
        public string Vorname { get; set; }
        public string ImagePath { get; set; }
        public byte[] ImageToByte { get; set; }
        public Image img { get; set; }
        public string Email { get; set; }
        public string Stadt { get; set; }
        public string Postleitzahl { get; set; }
        public string Straße { get; set; }
        public string Straßenummer { get; set; }
    }
}
