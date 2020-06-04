using System;
using System.Collections.Generic;

namespace PRO_001.Models
{
    public partial class TblGpsMantenimiento
    {
        public int IdMtto { get; set; }
        public int IdAsignaLocalizador { get; set; }
        public string TipoEvento { get; set; }
        public string NomInst { get; set; }
        public DateTime? FechaIns { get; set; }
        public string Observacion { get; set; }
        public int? KmsInicio { get; set; }

        public virtual TblGpsAsignacion IdAsignaLocalizadorNavigation { get; set; }
    }
}
