using System;
using System.Collections.Generic;

#nullable disable

namespace Addiction_Cure.core.Data
{
    public partial class Patientac
    {
        public Patientac()
        {
            Paymentacs = new HashSet<Paymentac>();
            Resulttsetacs = new HashSet<Resulttsetac>();
            Testacs = new HashSet<Testac>();
            Testemonialacs = new HashSet<Testemonialac>();
        }

        public decimal Patientid { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Imagename { get; set; }
        public string Level1 { get; set; }
        public decimal? Doctodid { get; set; }
        public decimal? Loginid { get; set; }
        public decimal? Categoryid { get; set; }

        public virtual Categoryac Category { get; set; }
        public virtual Dictorac Doctod { get; set; }
        public virtual Loginac Login { get; set; }
        public virtual ICollection<Paymentac> Paymentacs { get; set; }
        public virtual ICollection<Resulttsetac> Resulttsetacs { get; set; }
        public virtual ICollection<Testac> Testacs { get; set; }
        public virtual ICollection<Testemonialac> Testemonialacs { get; set; }
    }
}
