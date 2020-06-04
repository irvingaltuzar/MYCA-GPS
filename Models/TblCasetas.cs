using System;
using System.Collections.Generic;

namespace PRO_001.Models
{
    public partial class TblCasetas
    {
        public int IdCaseta { get; set; }
        public int? IdCasetaLis { get; set; }
        public int? IdProveedor { get; set; }
        public string Nombre { get; set; }
        public string Iave { get; set; }
        public decimal? MontoFijo { get; set; }
        public DateTime? FechaActualizado { get; set; }
        public decimal? Latitud { get; set; }
        public decimal? Longitud { get; set; }
        public DateTime? FechaIngreso { get; set; }
        public string UsuarioIngreso { get; set; }
        public DateTime? FechaModifico { get; set; }
        public string UsuarioModifico { get; set; }
        public string Estatus { get; set; }
    }
}
