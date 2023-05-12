using System;
using System.Collections.Generic;
using System.Text;

namespace Addiction_Cure.core.DTO
{
    public class TestWithquas
    {
        public decimal Quastionid { get; set; }
        public string Quastion { get; set; }

        public decimal Testid { get; set; }
        public decimal? Status { get; set; }
        public decimal? Patientid { get; set; }
        public DateTime? Testdate { get; set; }
        public decimal? TestNumber { get; set; }
    }
}
