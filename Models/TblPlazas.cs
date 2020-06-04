using System;
using System.Collections.Generic;

namespace PRO_001.Models
{
    public partial class TblPlazas
    {
        public int IdPlaza { get; set; }
        public int? IdPlazaLis { get; set; }
        public int? IdZona { get; set; }
        public int? IdGeoreferencia { get; set; }
        public int? IdEstado { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Matriz { get; set; }
        public DateTime? FechaIngreso { get; set; }
        public string UsuarioIngreso { get; set; }
        public DateTime? FechaModifico { get; set; }
        public string UsuarioModifico { get; set; }
        public string Estatus { get; set; }
    }
}
