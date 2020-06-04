using System;
using System.Collections.Generic;

namespace PRO_001.Models
{
    public partial class TblGpsAsignacion
    {
        public TblGpsAsignacion()
        {
            TblGpsMantenimiento = new HashSet<TblGpsMantenimiento>();
        }

        public int IdAsignaLocalizador { get; set; }
        public string UniNumEco { get; set; }
        public int IdLocalizador { get; set; }
        public int IdSim { get; set; }
        public string Estatus { get; set; }
        public DateTime? FechaAsignacion { get; set; }

        public virtual TblGpsLocalizadores IdLocalizadorNavigation { get; set; }
        public virtual TblMovilesSims IdSimNavigation { get; set; }
        public virtual TblUnidades UniNumEcoNavigation { get; set; }
        public virtual ICollection<TblGpsMantenimiento> TblGpsMantenimiento { get; set; }
    }
}
