using System;
using System.Collections.Generic;

namespace PRO_001.Models
{
    public partial class RhContratos
    {
        public int IdRec { get; set; }
        public int IdPersonalAdmon { get; set; }
        public string TipoContrato { get; set; }
        public string CausaAlta { get; set; }
        public string ObservacionAlta { get; set; }
        public DateTime? FechaIniVacaciones { get; set; }
        public int DiasVacaciones { get; set; }
        public double Antiguedad { get; set; }
        public string TallaCamisa { get; set; }
        public string TallaPantalon { get; set; }
        public string TallaZapatos { get; set; }
        public string NoLicencia { get; set; }
        public string LicCategoria { get; set; }
        public string LicTipoCarga { get; set; }
        public DateTime? FechaVenceLic { get; set; }
        public string NoMedicinaPreventiva { get; set; }
        public DateTime FechaVenceMedPreven { get; set; }
        public string RecConfiable { get; set; }
        public string NoRecConfiable { get; set; }
        public DateTime? FechaBaja { get; set; }
        public string CausaBaja { get; set; }
        public string ObservacionesBaja { get; set; }
        public string StatusGral { get; set; }
        public string EstadoSistemas { get; set; }
        public DateTime? EstadoFechaSistemas { get; set; }
        public string EstadoOperaciones { get; set; }
        public DateTime? EstadoFechaOperaciones { get; set; }
        public string EstadoMonitoreo { get; set; }
        public DateTime? EstadoFechaMonitoreo { get; set; }
        public string EstadoTrafico { get; set; }
        public DateTime? EstadoFechaTrafico { get; set; }
        public string EstadoMantenimiento { get; set; }
        public DateTime? EstadoFechaMantemiento { get; set; }
        public string EstadoRecHum { get; set; }
        public DateTime? EstadoFechaRecHum { get; set; }
        public string EstadoSeguridad { get; set; }
        public DateTime? EstadoFechaSeguridad { get; set; }

        public virtual RhPersonalAdmon IdPersonalAdmonNavigation { get; set; }
    }
}
