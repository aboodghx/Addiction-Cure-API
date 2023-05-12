using Addiction_Cure.core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Addiction_Cure.core.DTO
{
    public class quasWithcat
    {
        public decimal Quastionid { get; set; }
        public string Quastion { get; set; }
        public decimal? Categoryid { get; set; }

        public string Categoryname { get; set; }
        public string Image { get; set; }
        public string Abouttext { get; set; }
    }
}
