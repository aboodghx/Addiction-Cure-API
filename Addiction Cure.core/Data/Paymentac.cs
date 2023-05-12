using System;
using System.Collections.Generic;

#nullable disable

namespace Addiction_Cure.core.Data
{
    public partial class Paymentac
    {
        public decimal Paymentid { get; set; }
        public decimal? Amount { get; set; }
        public DateTime? Paydate { get; set; }
        public decimal? Patientid { get; set; }

        public virtual Patientac Patient { get; set; }
    }
}
