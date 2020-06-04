using System;
using System.Collections.Generic;

namespace PRO_001.Models
{
    public partial class TblMovilesLineasTiusa
    {
        public int IdLinea { get; set; }
        public int IdCuentaPadre { get; set; }
        public int IdPlan { get; set; }
        public string NoTelefono { get; set; }
        public string CuentaHija { get; set; }
        public DateTime FechaAlta { get; set; }
        public string Estado { get; set; }

        public virtual TblMovilesCuentasPadre IdCuentaPadreNavigation { get; set; }
        public virtual TblMovilesPlanes IdPlanNavigation { get; set; }
    }
}
