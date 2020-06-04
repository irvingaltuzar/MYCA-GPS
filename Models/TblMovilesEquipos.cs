using System;
using System.Collections.Generic;

namespace PRO_001.Models
{
    public partial class TblMovilesEquipos
    {
        public TblMovilesEquipos()
        {
            TblMovilesAsignacionCelulares = new HashSet<TblMovilesAsignacionCelulares>();
        }

        public int IdEquipo { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Imei { get; set; }
        public string StatusEquipo { get; set; }
        public DateTime FechaAlta { get; set; }

        public virtual ICollection<TblMovilesAsignacionCelulares> TblMovilesAsignacionCelulares { get; set; }
    }
}
