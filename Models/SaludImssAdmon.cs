using System;
using System.Collections.Generic;

namespace PRO_001.Models
{
    public partial class SaludImssAdmon
    {
        public int IdImssPersonal { get; set; }
        public int IdPersonalAdmon { get; set; }
        public string NoImss { get; set; }
        public string NoClinica { get; set; }
        public string DireccionClinica { get; set; }
        public string TipoSangre { get; set; }
        public string EstadoSalud { get; set; }
        public string Alergias { get; set; }
        public string Enfermedades { get; set; }
        public string Psicofisica { get; set; }
        public string Status { get; set; }
    }
}
