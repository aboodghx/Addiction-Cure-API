using System;
using System.Collections.Generic;

#nullable disable

namespace Addiction_Cure.core.Data
{
    public partial class Loginac
    {
        public Loginac()
        {
            Dictoracs = new HashSet<Dictorac>();
            Patientacs = new HashSet<Patientac>();
        }

        public decimal Loginid { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public decimal? Roleid { get; set; }

        public virtual Roleac Role { get; set; }
        public virtual ICollection<Dictorac> Dictoracs { get; set; }
        public virtual ICollection<Patientac> Patientacs { get; set; }
    }
}
