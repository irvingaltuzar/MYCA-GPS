using System;
using System.Collections.Generic;

namespace PRO_001.Models
{
    public partial class TblClientes
    {
        public int IdCliente { get; set; }
        public int? IdClienteLis { get; set; }
        public int? IdPlaza { get; set; }
        public int? IdTipoMoneda { get; set; }
        public int? IdIva { get; set; }
        public string AuxContable { get; set; }
        public string Email { get; set; }
        public string Observaciones { get; set; }
        public string Domicilio { get; set; }
        public string Localidad { get; set; }
        public string CodPostal { get; set; }
        public string Telefono { get; set; }
        public string Fax { get; set; }
        public string Alias { get; set; }
        public string Nombre { get; set; }
        public string Rfc { get; set; }
        public string NomContact1 { get; set; }
        public string TelContact1 { get; set; }
        public string EmailContact1 { get; set; }
        public string NomContact2 { get; set; }
        public string TelContact2 { get; set; }
        public string EmailContact2 { get; set; }
        public string Matriz { get; set; }
        public int? ClienteQuePaga { get; set; }
        public int? PersonaFisica { get; set; }
        public int? TipoRetencion { get; set; }
        public string IdIngreso { get; set; }
        public string IdModifico { get; set; }
        public DateTime? FechaIngreso { get; set; }
        public DateTime? FechaModifico { get; set; }
        public decimal? FactorIva { get; set; }
        public string CuentaCliente { get; set; }
        public string CuentaSbcliente { get; set; }
        public int? ConsecCobranza { get; set; }
        public int? ClienteFact { get; set; }
        public int? AreaCobranza { get; set; }
        public string Estatus { get; set; }
        public string CveUsoCfdi { get; set; }
    }
}
