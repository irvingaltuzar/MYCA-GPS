using System;
using System.Collections.Generic;

namespace PRO_001.Models
{
    public partial class TblZonas
    {
        public int IdZona { get; set; }
        public int? IdZonaLis { get; set; }
        public string Nombre { get; set; }
        public DateTime? FechaIngreso { get; set; }
        public string UsuarioIngreso { get; set; }
        public DateTime? FechaModifico { get; set; }
        public string UsuarioModifico { get; set; }
        public string Estatus { get; set; }
    }
}
