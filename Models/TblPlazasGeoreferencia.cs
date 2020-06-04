using System;
using System.Collections.Generic;

namespace PRO_001.Models
{
    public partial class TblPlazasGeoreferencia
    {
        public int IdGeoreferencia { get; set; }
        public string Etiqueta { get; set; }
        public decimal? Latitud { get; set; }
        public decimal? Longitud { get; set; }
        public string InegiSource { get; set; }
        public string InegiTarget { get; set; }
        public string InegiRoutingNet { get; set; }
        public string Estatus { get; set; }
    }
}
