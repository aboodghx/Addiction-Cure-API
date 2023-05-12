using System;
using System.Collections.Generic;

#nullable disable

namespace Addiction_Cure.core.Data
{
    public partial class Testemonialac
    {
        public decimal Tesemonialid { get; set; }
        public string Status { get; set; }
        public string Messageuser { get; set; }
        public decimal? Patientid { get; set; }

        public virtual Patientac Patient { get; set; }
    }
}
