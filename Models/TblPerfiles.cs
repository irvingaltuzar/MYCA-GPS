using System;
using System.Collections.Generic;

namespace PRO_001.Models
{
    public partial class TblPerfiles
    {
        public string Perfil { get; set; }
        public string NombreDepto { get; set; }
        public string Clasificacion { get; set; }
        public DateTime? FechaIngreso { get; set; }
        public string Usuario { get; set; }
        public DateTime? FechaModifico { get; set; }
        public string Estado { get; set; }
    }
}
