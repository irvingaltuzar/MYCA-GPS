using System;
using System.Collections.Generic;

namespace PRO_001.Models
{
    public partial class TblUniAsignacionIave
    {
        public int IdAsignacionIave { get; set; }
        public int IdIave { get; set; }
        public string UniNumEco { get; set; }
        public DateTime FechaAsignacion { get; set; }
        public string Observaciones { get; set; }
        public DateTime StatusAsignacion { get; set; }

        public virtual TblUniIaves IdIaveNavigation { get; set; }
        public virtual TblUnidades UniNumEcoNavigation { get; set; }
    }
}
