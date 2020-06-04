using System;
using System.Collections.Generic;

namespace PRO_001.Models
{
    public partial class TblNotasCargoPerfil
    {
        public int IdConcepto { get; set; }
        public string Concepto { get; set; }
        public string Perfil { get; set; }
        public string NombreDepto { get; set; }
        public DateTime FechaIngreso { get; set; }
        public string Usuario { get; set; }
    }
}
