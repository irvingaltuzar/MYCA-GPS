using System;
using System.Collections.Generic;

namespace PRO_001.Models.POSITIONSDB
{
    public partial class TblPositionsLast
    {
        public string DeviceProveedor { get; set; }
        public string DeviceId { get; set; }
        public string DeviceEco { get; set; }
        public string DeviceClass { get; set; }
        public DateTime? PosFechahora { get; set; }
        public double? PosLatitud { get; set; }
        public double? PosLogitud { get; set; }
        public int? PosAngulo { get; set; }
        public string PosDireccion { get; set; }
        public decimal? PosOdometro { get; set; }
        public decimal? PosVelocidad { get; set; }
        public int? PosIgnicion { get; set; }
        public decimal? PosCombistiblenivel { get; set; }
        public DateTime? FechahoraUpdate { get; set; }
    }
}
