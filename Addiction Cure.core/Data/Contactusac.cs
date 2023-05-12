using System;
using System.Collections.Generic;

#nullable disable

namespace Addiction_Cure.core.Data
{
    public partial class Contactusac
    {
        public decimal Contactid { get; set; }
        public string Name { get; set; }
        public decimal? Phone { get; set; }
        public string Email { get; set; }
        public string Subject { get; set; }
        public string Mesg { get; set; }
    }
}
