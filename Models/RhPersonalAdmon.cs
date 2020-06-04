using System;
using System.Collections.Generic;

namespace PRO_001.Models
{
    public partial class RhPersonalAdmon
    {
        public RhPersonalAdmon()
        {
            AdmonTelFijos = new HashSet<AdmonTelFijos>();
            AdmonTelMoviles = new HashSet<AdmonTelMoviles>();
            RhContratos = new HashSet<RhContratos>();
            RhPensionAlimenticia = new HashSet<RhPensionAlimenticia>();
            TblMovilesAsignacionCelulares = new HashSet<TblMovilesAsignacionCelulares>();
        }

        public int IdPersonalAdmon { get; set; }
        public int IdCategoria { get; set; }
        public int IdPerfil { get; set; }
        public string Nombre { get; set; }
        public string ApePaterno { get; set; }
        public string ApeMaterno { get; set; }
        public DateTime FechaNac { get; set; }
        public int Edad { get; set; }
        public string Sexo { get; set; }
        public string LugarNacimiento { get; set; }
        public string NombrePadre { get; set; }
        public string NombreMadre { get; set; }
        public string EstadoCivil { get; set; }
        public int NoHijos { get; set; }
        public string NomConyuge { get; set; }
        public string Calle { get; set; }
        public string NoExt { get; set; }
        public string NoInt { get; set; }
        public string Referencia { get; set; }
        public string Col { get; set; }
        public string Municipio { get; set; }
        public string Cp { get; set; }
        public string Estado { get; set; }
        public string Pais { get; set; }
        public string NivelEscolar { get; set; }
        public string Curp { get; set; }
        public string Rfc { get; set; }
        public string Visa { get; set; }
        public string Nip { get; set; }
        public string Email { get; set; }
        public string Infonavit { get; set; }
        public double InfoDescVsm { get; set; }
        public double InfoDescFijo { get; set; }
        public double InfoDescPorcentaje { get; set; }
        public string Fonacot { get; set; }
        public double DescFonacot { get; set; }
        public string UsuarioIngresa { get; set; }
        public DateTime FechaUsuarioIngresa { get; set; }
        public string UsuarioModifica { get; set; }
        public DateTime? FechaUsuarioModifica { get; set; }
        public string AdmonImagen { get; set; }

        public virtual AdmonPerfiles IdPerfilNavigation { get; set; }
        public virtual ICollection<AdmonTelFijos> AdmonTelFijos { get; set; }
        public virtual ICollection<AdmonTelMoviles> AdmonTelMoviles { get; set; }
        public virtual ICollection<RhContratos> RhContratos { get; set; }
        public virtual ICollection<RhPensionAlimenticia> RhPensionAlimenticia { get; set; }
        public virtual ICollection<TblMovilesAsignacionCelulares> TblMovilesAsignacionCelulares { get; set; }
    }
}
