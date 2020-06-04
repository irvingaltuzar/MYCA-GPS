using System;
using System.Collections.Generic;

namespace PRO_001.Models
{
    public partial class TblUniIaves
    {
        public TblUniIaves()
        {
            TblUniAsignacionIave = new HashSet<TblUniAsignacionIave>();
        }

        public int IdIave { get; set; }
        public string Tag { get; set; }
        public string Tipo { get; set; }
        public string StatusIave { get; set; }
        public DateTime? FechaAlta { get; set; }

        public virtual ICollection<TblUniAsignacionIave> TblUniAsignacionIave { get; set; }
    }
}
