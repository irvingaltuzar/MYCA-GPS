using System;
using System.Collections.Generic;

namespace PRO_001.Models
{
    public partial class RhPensionAlimenticia
    {
        public int IdPensionPersonal { get; set; }
        public int IdPersonalAdmon { get; set; }
        public string NoCuenta { get; set; }
        public double? PensionPorcentaje { get; set; }
        public string PensionAlimNombre { get; set; }
        public string PensionAlimApePaterno { get; set; }
        public string PensionAlimApeMaterno { get; set; }
        public string Status { get; set; }

        public virtual RhPersonalAdmon IdPersonalAdmonNavigation { get; set; }
    }
}
