using System;
using System.Collections.Generic;

namespace PRO_001.Models
{
    public partial class TblMovilesSims
    {
        public TblMovilesSims()
        {
            TblGpsAsignacion = new HashSet<TblGpsAsignacion>();
            TblMovilesAsignacionCelulares = new HashSet<TblMovilesAsignacionCelulares>();
        }

        public int IdSim { get; set; }
        public int IdLinea { get; set; }
        public string NoSim { get; set; }
        public string NoVersion { get; set; }
        public DateTime FechaAlta { get; set; }
        public string Estatus { get; set; }

        public virtual ICollection<TblGpsAsignacion> TblGpsAsignacion { get; set; }
        public virtual ICollection<TblMovilesAsignacionCelulares> TblMovilesAsignacionCelulares { get; set; }
    }
}
