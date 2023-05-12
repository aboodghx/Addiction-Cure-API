using System;
using System.Collections.Generic;
using System.Text;

namespace Addiction_Cure.core.DTO
{
    public class patBy
    {
        public decimal Patientid { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Imagename { get; set; }
        public string Level1 { get; set; }
        public decimal? Doctodid { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public decimal? Roleid { get; set; }
        public decimal? Categoryid { get; set; }
        public string Categoryname { get; set; }
        public string Image { get; set; }
        public string Abouttext { get; set; }

        public decimal? Loginid { get; set; }
    }
}
