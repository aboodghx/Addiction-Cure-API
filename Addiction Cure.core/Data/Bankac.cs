using System;
using System.Collections.Generic;

#nullable disable

namespace Addiction_Cure.core.Data
{
    public partial class Bankac
    {
        public decimal Bankid { get; set; }
        public string Name { get; set; }
        public string Cardnumper { get; set; }
        public string Cvv { get; set; }
        public string Amount { get; set; }
    }
}
