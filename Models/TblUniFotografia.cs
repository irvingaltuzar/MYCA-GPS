using System;
using System.Collections.Generic;

namespace PRO_001.Models
{
    public partial class TblUniFotografia
    {
        public int IdFotografia { get; set; }
        public string UniNumEco { get; set; }
        public string UniEstadoSistemas { get; set; }
        public DateTime? UniEstadoFechaSistemas { get; set; }
        public string UniEstadoMonitoreo { get; set; }
        public DateTime? UniEstadoFechaMonitoreo { get; set; }
        public string UniEstadoOperaciones { get; set; }
        public DateTime? UniEstadoFechaOperaciones { get; set; }
        public string UniEstadoTrafico { get; set; }
        public DateTime? UniEstadoFechaTrafico { get; set; }
        public string UniEstadoMantenimiento { get; set; }
        public DateTime? UniEstadoFechaMantenimiento { get; set; }
        public string UniEstadoRechumanos { get; set; }
        public DateTime? UniEstadoFechaRechumanos { get; set; }
        public int? UniCliId { get; set; }
        public string UniCliNombre { get; set; }
        public string UniCliEstado { get; set; }
        public DateTime? UniFechaClieUpdate { get; set; }
        public string UniUserCliUpdater { get; set; }

        public virtual TblUnidades UniNumEcoNavigation { get; set; }
    }
}
