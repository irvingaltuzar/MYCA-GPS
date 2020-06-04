using System;
using System.Collections.Generic;

namespace PRO_001.Models
{
    public partial class TblIncidenciaPerfil
    {
        public int IdIncidencia { get; set; }
        public string Incidencia { get; set; }
        public double ValorIncidencia { get; set; }
        public string Departamento { get; set; }
        public string Perfil { get; set; }
        public DateTime FechaIngreso { get; set; }
        public string Usuario { get; set; }
    }
}
