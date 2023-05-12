using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Text;

namespace Addiction_Cure.core.DTO
{
    public class DoctorEmail
    {
        public string DoctorName { get; set; }
        public string PatientName { get; set; }
        public string BodyEmail { get; set; }
        public string PatientEmail { get; set; }
        public DateTime? Datetest { get; set; }
    }
}
