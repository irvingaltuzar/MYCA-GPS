using System;
using System.Collections.Generic;

namespace PRO_001.Models
{
    public partial class TblMovilesCuentasPadre
    {
        public TblMovilesCuentasPadre()
        {
            TblMovilesLineasTiusa = new HashSet<TblMovilesLineasTiusa>();
        }

        public int IdCuentaPadre { get; set; }
        public int CuentaPadre { get; set; }
        public string CpNombre { get; set; }
        public DateTime FechaAlta { get; set; }

        public virtual ICollection<TblMovilesLineasTiusa> TblMovilesLineasTiusa { get; set; }
    }
}
