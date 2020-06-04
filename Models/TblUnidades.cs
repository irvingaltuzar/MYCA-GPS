using System;
using System.Collections.Generic;

namespace PRO_001.Models
{
    public partial class TblUnidades
    {
        public TblUnidades()
        {
            TblGpsAsignacion = new HashSet<TblGpsAsignacion>();
            TblUniAsignacionIave = new HashSet<TblUniAsignacionIave>();
            TblUniFotografia = new HashSet<TblUniFotografia>();
            TblUniImagenes = new HashSet<TblUniImagenes>();
            TblUniMttoOdometro = new HashSet<TblUniMttoOdometro>();
        }

        public string UniNumEco { get; set; }
        public int IdTipoUnidad { get; set; }
        public int IdFlotilla { get; set; }
        public string FactCompra { get; set; }
        public DateTime? FechaFact { get; set; }
        public double CostoUnidad { get; set; }
        public string CentroCosto { get; set; }
        public string NoInventario { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string AnioUnidad { get; set; }
        public string ClaveVehiculo { get; set; }
        public string PesoUnidad { get; set; }
        public string SerieMotor { get; set; }
        public string SerieChasis { get; set; }
        public int TotalLlantas { get; set; }
        public string LlantaExtra { get; set; }
        public string Color { get; set; }
        public string VehNoNiv { get; set; }
        public string ObservacionGral { get; set; }
        public string Estatus { get; set; }
        public DateTime FechaAlta { get; set; }
        public DateTime? BajaFecha { get; set; }
        public string BajaCausas { get; set; }
        public string BajaObservacion { get; set; }
        public string UsuarioRegistra { get; set; }
        public DateTime FechaRegistro { get; set; }
        public string UsuarioModifica { get; set; }
        public DateTime? FechaModifica { get; set; }

        public virtual TblUniTipoUnidad IdTipoUnidadNavigation { get; set; }
        public virtual TblUniGestoria TblUniGestoria { get; set; }
        public virtual TblUniMttoTractores TblUniMttoTractores { get; set; }
        public virtual ICollection<TblGpsAsignacion> TblGpsAsignacion { get; set; }
        public virtual ICollection<TblUniAsignacionIave> TblUniAsignacionIave { get; set; }
        public virtual ICollection<TblUniFotografia> TblUniFotografia { get; set; }
        public virtual ICollection<TblUniImagenes> TblUniImagenes { get; set; }
        public virtual ICollection<TblUniMttoOdometro> TblUniMttoOdometro { get; set; }
    }
}
