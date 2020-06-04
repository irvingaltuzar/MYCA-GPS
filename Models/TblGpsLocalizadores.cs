using System;
using System.Collections.Generic;

namespace PRO_001.Models
{
    public partial class TblGpsLocalizadores
    {
        public TblGpsLocalizadores()
        {
            TblGpsAsignacion = new HashSet<TblGpsAsignacion>();
        }

        public int IdLocalizador { get; set; }
        public string Nuid { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Imei { get; set; }
        public string Estado { get; set; }

        public virtual ICollection<TblGpsAsignacion> TblGpsAsignacion { get; set; }
    }
}
