using System;
using System.Collections.Generic;

namespace PRO_001.Models
{
    public partial class TblUniGestoria
    {
        public string UniNumEco { get; set; }
        public string VehPlacas { get; set; }
        public string VehRemplacamiento { get; set; }
        public DateTime? VehFechaRemplacamiento { get; set; }
        public string VehTarjCirculacion { get; set; }
        public string VehPolizaSeg { get; set; }
        public DateTime? FechaVenSeguro { get; set; }
        public string VehSeguroInciso { get; set; }
        public string VehObservaciones { get; set; }
        public string FileTarjetaCirculacion { get; set; }
        public string FileAutorizacionPCirculacion { get; set; }
        public string FilePolizaSeguro { get; set; }
        public string FileFisicoMecanica { get; set; }
        public string FileBajaContaminantes { get; set; }
        public string FileCerFumigacion { get; set; }
        public string FileTarjetaIave { get; set; }
        public string FileNoSerie { get; set; }

        public virtual TblUnidades UniNumEcoNavigation { get; set; }
    }
}
