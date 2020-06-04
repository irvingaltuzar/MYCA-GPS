using System;
using System.Collections.Generic;

namespace PRO_001.Models
{
    public partial class TblConvenios
    {
        public int IdConvenio { get; set; }
        public int? IdConvenioLis { get; set; }
        public int IdCliente { get; set; }
        public int? IdRuta { get; set; }
        public int? IdRemitente { get; set; }
        public int? IdDestinatario { get; set; }
        public int? IdTipoMoneda { get; set; }
        public int? IdOrigen { get; set; }
        public int? IdDestino { get; set; }
        public int? IdTipoOperacion { get; set; }
        public int? IdIva { get; set; }
        public string IdIngreso { get; set; }
        public string IdModifico { get; set; }
        public DateTime? FechaIngreso { get; set; }
        public DateTime? FechaModifico { get; set; }
        public int? AreaCobranza { get; set; }
        public string Descripcion { get; set; }
        public string RecogerEn { get; set; }
        public string EntregarEn { get; set; }
        public string Observaciones { get; set; }
        public string Estatus { get; set; }
        public decimal? ValorUnitario { get; set; }
        public decimal? ValorTonelada { get; set; }
        public decimal? ValorKms { get; set; }
        public string ValorDeclarado { get; set; }
        public decimal? MontoFlete { get; set; }
        public decimal? MontoSeguro { get; set; }
        public decimal? MontoManiobras { get; set; }
        public decimal? MontoAutopistas { get; set; }
        public decimal? MontoOtros { get; set; }
        public decimal? MontoSubtotal { get; set; }
        public decimal? MontoIva { get; set; }
        public decimal? MontoTotal { get; set; }
        public decimal? KmsConvenio { get; set; }
        public decimal? FactorIva { get; set; }
        public decimal? TipoCambioConvenio { get; set; }
        public string TipoPago { get; set; }
        public string TipoCobro { get; set; }
        public string TipoServ { get; set; }
        public decimal? ConvOperador { get; set; }
        public decimal? ConvPermisionario { get; set; }
    }
}
