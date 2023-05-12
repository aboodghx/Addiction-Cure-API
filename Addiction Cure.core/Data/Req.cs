using System;
using System.Collections.Generic;

#nullable disable

namespace Addiction_Cure.core.Data
{
    public partial class Req
    {
        public decimal Reqid { get; set; }
        public decimal? Status { get; set; }
        public decimal? Patientid { get; set; }
        public decimal? Doctorid { get; set; }
    }
}
