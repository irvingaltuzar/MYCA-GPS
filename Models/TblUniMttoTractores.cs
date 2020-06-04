using System;
using System.Collections.Generic;

namespace PRO_001.Models
{
    public partial class TblUniMttoTractores
    {
        public string UniNumEco { get; set; }
        public string MarcaMotor { get; set; }
        public string ModelMotor { get; set; }
        public string Transmision { get; set; }
        public int? NoCilindros { get; set; }
        public string PotenciaMotor { get; set; }
        public string PulgCubMotor { get; set; }
        public string TipoCombustible { get; set; }
        public double? CapacidadCombustible { get; set; }
        public double? RendiEsperado { get; set; }
        public double? CapAceiteMotor { get; set; }
        public double? RendiAceiteMotor { get; set; }
        public double? CapAceiteTransmicion { get; set; }
        public double? RendAceiteTransmicion { get; set; }
        public double? CapAceiteDiferencialD { get; set; }
        public double? RendAceiteDiferencialD { get; set; }
        public double? CapAceiteDiferencialT { get; set; }
        public double? RendAceiteDiferencialT { get; set; }
        public string Observaciones { get; set; }

        public virtual TblUnidades UniNumEcoNavigation { get; set; }
    }
}
