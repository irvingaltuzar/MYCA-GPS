using System;
using System.Collections.Generic;

namespace PRO_001.Models
{
    public partial class TblConveniosConceptos
    {
        public int? IdConceptoLis { get; set; }
        public int IdConvenio { get; set; }
        public int IdCliente { get; set; }
        public int Orden { get; set; }
        public string DescripcionConcepto { get; set; }
        public decimal? Monto { get; set; }
        public decimal? MontoRetencion { get; set; }
        public decimal? MontoIva { get; set; }
        public decimal? MontoTotal { get; set; }
    }
}
