using System;
using System.Collections.Generic;

namespace PRO_001.Models.POSITIONSDB
{
    public partial class TblLastPosWebApi
    {
        public int Id { get; set; }
        public string Objectno { get; set; }
        public string Objectuid { get; set; }
        public string Objectname { get; set; }
        public string Objectclassname { get; set; }
        public string Objecttype { get; set; }
        public string Deleted { get; set; }
        public DateTime? Msgtime { get; set; }
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }
        public decimal? LatitudeMdeg { get; set; }
        public decimal? LongitudeMdeg { get; set; }
        public DateTime? PosTime { get; set; }
        public string Postext { get; set; }
        public string PostextShort { get; set; }
        public string Status { get; set; }
        public int? DriverCurrentworkstate { get; set; }
        public int? CodriverCurrentworkstate { get; set; }
        public long? Odometer { get; set; }
        public int? Ignition { get; set; }
        public DateTime? IgnitionTime { get; set; }
        public int? Tripmode { get; set; }
        public int? Standstill { get; set; }
        public int? Pndconn { get; set; }
        public decimal? Lastmsgid { get; set; }
        public int? Speed { get; set; }
        public int? Course { get; set; }
        public int? Direction { get; set; }
        public int? Fuellevel { get; set; }
        public DateTime? FechahoraRecepcion { get; set; }
        public DateTime? FechahoraInsert { get; set; }
        public int? StatusGuardian { get; set; }
    }
}
