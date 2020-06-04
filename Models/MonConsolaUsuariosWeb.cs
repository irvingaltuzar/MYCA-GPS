using System;
using System.Collections.Generic;

namespace PRO_001.Models
{
    public partial class MonConsolaUsuariosWeb
    {
        public int IdUser { get; set; }
        public string NombreCompleto { get; set; }
        public string Correo { get; set; }
        public string Pass { get; set; }
        public string Cliente { get; set; }
        public string Logo { get; set; }
        public DateTime? FechaIngreso { get; set; }
        public DateTime? FechaModifica { get; set; }
        public DateTime? FechaUltimoAcceso { get; set; }
        public string Estado { get; set; }
        public string ExtLogo { get; set; }

        //public bool RemeberMe { get; set; }
    }
}
