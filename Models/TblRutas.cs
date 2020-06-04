using System;
using System.Collections.Generic;

namespace PRO_001.Models
{
    public partial class TblRutas
    {
        public int IdRuta { get; set; }
        public int? IdRutaLis { get; set; }
        public int? IdOrigen { get; set; }
        public int? IdDestino { get; set; }
        public string Nombre { get; set; }
        public decimal? KmRuta { get; set; }
        public int? TiempoEstimado { get; set; }
        public decimal? KmLts { get; set; }
        public string PathRuta { get; set; }
        public DateTime? FechaIngreso { get; set; }
        public string UsuarioIngreso { get; set; }
        public DateTime? FechaModifico { get; set; }
        public string UsuarioModifico { get; set; }
        public string Estatus { get; set; }
    }
}
