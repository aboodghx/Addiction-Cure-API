using System;
using System.Collections.Generic;

#nullable disable

namespace Addiction_Cure.core.Data
{
    public partial class Quastionsac
    {
        public Quastionsac()
        {
            Testacs = new HashSet<Testac>();
        }

        public decimal Quastionid { get; set; }
        public string Quastion { get; set; }
        public decimal? Categoryid { get; set; }

        public virtual Categoryac Category { get; set; }
        public virtual ICollection<Testac> Testacs { get; set; }
    }
}
