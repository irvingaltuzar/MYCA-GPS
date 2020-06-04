using System;
using System.Collections.Generic;

namespace PRO_001.Models
{
    public partial class GeneralLocalidades
    {
        public int? CveEnt { get; set; }
        public int? CveMun { get; set; }
        public int? CveLoc { get; set; }
        public string NomLoc { get; set; }
        public string Ambito { get; set; }
        public string LatDec { get; set; }
        public string LonDec { get; set; }
        public string Altitud { get; set; }
    }
}
