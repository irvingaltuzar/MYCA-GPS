using System;
using System.Collections.Generic;

namespace PRO_001.Models
{
    public partial class RhCuentasBancos
    {
        public int IdCuentaBanco { get; set; }
        public int IdPersonalAdmon { get; set; }
        public string AdmonCuentaBancos { get; set; }
        public string TipoCuenta { get; set; }
        public string TitularCuenta { get; set; }
        public string NombreTitular { get; set; }
        public string ApePaternoTitular { get; set; }
        public string ApeMaternoTitular { get; set; }
        public string StatusCuenta { get; set; }
    }
}
