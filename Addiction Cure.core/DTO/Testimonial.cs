using System;
using System.Collections.Generic;
using System.Text;

namespace Addiction_Cure.core.DTO
{
    public class Testimonial
    {
        public decimal Tesemonialid { get; set; }
        public string Status { get; set; }
        public string Messageuser { get; set; }
        public decimal Patientid { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Imagename { get; set; }
    }
}
