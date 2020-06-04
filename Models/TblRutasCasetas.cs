using System;
using System.Collections.Generic;

namespace PRO_001.Models
{
    public partial class TblRutasCasetas
    {
        public int IdRuta { get; set; }
        public int? IdCaseta { get; set; }
        public int Orden { get; set; }
    }
}
