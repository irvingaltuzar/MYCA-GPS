using System;
using System.Collections.Generic;

namespace PRO_001.Models
{
    public partial class TblMovilesAsignacionCelulares
    {
        public int IdAsignacion { get; set; }
        public int IdPersonalAdmon { get; set; }
        public int IdEquipo { get; set; }
        public int IdSim { get; set; }
        public string CuentaGmail { get; set; }
        public int? NipSeguridad { get; set; }
        public string Comentarios { get; set; }
        public int PrecioResguardo { get; set; }
        public DateTime FechaAsignacion { get; set; }
        public DateTime FechaActualizacion { get; set; }
        public string Estatus { get; set; }

        public virtual TblMovilesEquipos IdEquipoNavigation { get; set; }
        public virtual RhPersonalAdmon IdPersonalAdmonNavigation { get; set; }
        public virtual TblMovilesSims IdSimNavigation { get; set; }
    }
}
