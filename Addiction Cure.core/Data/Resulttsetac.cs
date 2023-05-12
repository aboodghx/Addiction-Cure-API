using System;
using System.Collections.Generic;

#nullable disable

namespace Addiction_Cure.core.Data
{
    public partial class Resulttsetac
    {
        public decimal Resulttestid { get; set; }
        public string Resulttest { get; set; }
        public string Perioddate { get; set; }
        public string Description { get; set; }
        public decimal? Numberoftest { get; set; }
        public DateTime? Datetest { get; set; }
        public decimal? Patientid { get; set; }

        public virtual Patientac Patient { get; set; }
    }
}
