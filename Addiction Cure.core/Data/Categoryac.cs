using System;
using System.Collections.Generic;

#nullable disable

namespace Addiction_Cure.core.Data
{
    public partial class Categoryac
    {
        public Categoryac()
        {
            Dictoracs = new HashSet<Dictorac>();
            Patientacs = new HashSet<Patientac>();
            Quastionsacs = new HashSet<Quastionsac>();
        }

        public decimal Categoryid { get; set; }
        public string Categoryname { get; set; }
        public string Image { get; set; }
        public string Abouttext { get; set; }

        public virtual ICollection<Dictorac> Dictoracs { get; set; }
        public virtual ICollection<Patientac> Patientacs { get; set; }
        public virtual ICollection<Quastionsac> Quastionsacs { get; set; }

    }
}
