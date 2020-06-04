using System;
using System.Collections.Generic;

namespace PRO_001.Models
{
    public partial class TblUniTipoUnidad
    {
        public TblUniTipoUnidad()
        {
            TblUnidades = new HashSet<TblUnidades>();
        }

        public int IdTipoUnidad { get; set; }
        public string TipoUnidad { get; set; }
        public string Descripcion { get; set; }
        public DateTime? FechaActualiza { get; set; }
        public string Estatus { get; set; }

        public virtual ICollection<TblUnidades> TblUnidades { get; set; }
    }
}
