using System;
using System.Collections.Generic;
using System.Text;

namespace Addiction_Cure.core.DTO
{
    public class ResultTestDto
    {
        public decimal Resulttestid { get; set; }
        public string Resulttest { get; set; }
        public string Perioddate { get; set; }
        public string Description { get; set; }
        public decimal? Numberoftest { get; set; }
        public DateTime? Datetest { get; set; }
        public decimal? Patientid { get; set; }

        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Imagename { get; set; }
        public string Level1 { get; set; }
    }
}
