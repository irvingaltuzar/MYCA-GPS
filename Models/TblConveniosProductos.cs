using System;
using System.Collections.Generic;

namespace PRO_001.Models
{
    public partial class TblConveniosProductos
    {
        public int IdConvenio { get; set; }
        public int IdCliente { get; set; }
        public int Orden { get; set; }
        public int? IdProducto { get; set; }
        public int? IdFraccion { get; set; }
        public int? IdEmbalaje { get; set; }
        public string EmbalajeProd { get; set; }
        public string FraccionProd { get; set; }
        public string DescripcionProducto { get; set; }
        public decimal? Cantidad { get; set; }
        public decimal? Peso { get; set; }
        public decimal? PesoEstimado { get; set; }
        public decimal? Volumen { get; set; }
        public decimal? Importe { get; set; }
        public decimal? ImporteTotal { get; set; }
    }
}
