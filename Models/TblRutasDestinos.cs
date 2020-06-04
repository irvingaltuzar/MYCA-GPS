using System;
using System.Collections.Generic;

namespace PRO_001.Models
{
    public partial class TblRutasDestinos
    {
        public int IdRuta { get; set; }
        public string Direccion { get; set; }
        public decimal? Latitud { get; set; }
        public decimal? Longitud { get; set; }
        public int Orden { get; set; }
    }
}
