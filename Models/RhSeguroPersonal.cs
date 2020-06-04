using System;
using System.Collections.Generic;

namespace PRO_001.Models
{
    public partial class RhSeguroPersonal
    {
        public int IdSeguroPersonal { get; set; }
        public int IdPersonalAdmon { get; set; }
        public string NoSeguro { get; set; }
        public string NoInciso { get; set; }
        public string BeneficiarioNombre { get; set; }
        public string BeneficiarioApePaterno { get; set; }
        public string BeneficiarioApeMaterno { get; set; }
        public int? SeguroPorcentaje { get; set; }
        public string Parentesco { get; set; }
        public string Status { get; set; }
    }
}
