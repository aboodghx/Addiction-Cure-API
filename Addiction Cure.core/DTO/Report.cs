using System;
using System.Collections.Generic;
using System.Text;

namespace Addiction_Cure.core.DTO
{
    public class Report
    { 

        public string Patientfname { get; set; } 
        public string Patientlname { get; set; } 
        public int Amount { get; set; }
        public int Total { get; set; }
        public DateTime? Paydate { get; set; }
    }
}
