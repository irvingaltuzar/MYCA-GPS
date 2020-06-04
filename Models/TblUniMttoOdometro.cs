using System;
using System.Collections.Generic;

namespace PRO_001.Models
{
    public partial class TblUniMttoOdometro
    {
        public int IdUniOdometro { get; set; }
        public string UniNumEco { get; set; }
        public double Odometro { get; set; }
        public string Observacion { get; set; }
        public DateTime FechaOdometro { get; set; }
        public string Estatus { get; set; }

        public virtual TblUnidades UniNumEcoNavigation { get; set; }
    }
}
