using System;
using System.Collections.Generic;

namespace PRO_001.Models
{
    public partial class TblCasetasTarifas
    {
        public int IdTarifa { get; set; }
        public int? IdTarifaLis { get; set; }
        public int? IdCaseta { get; set; }
        public int? NoEjes { get; set; }
        public decimal? MontoTarifa { get; set; }
        public decimal? MontoIave { get; set; }
    }
}
