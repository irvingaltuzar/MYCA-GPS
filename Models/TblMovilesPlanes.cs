using System;
using System.Collections.Generic;

namespace PRO_001.Models
{
    public partial class TblMovilesPlanes
    {
        public TblMovilesPlanes()
        {
            TblMovilesLineasTiusa = new HashSet<TblMovilesLineasTiusa>();
        }

        public int IdPlan { get; set; }
        public string NomPlan { get; set; }
        public string TipoPlan { get; set; }
        public DateTime FechaAlta { get; set; }
        public string Estado { get; set; }
        public double? CostoPlanSinIva { get; set; }
        public double? CostoAnualidad { get; set; }

        public virtual ICollection<TblMovilesLineasTiusa> TblMovilesLineasTiusa { get; set; }
    }
}
