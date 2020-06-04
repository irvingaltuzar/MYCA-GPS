using System;
using System.Collections.Generic;

namespace PRO_001.Models
{
    public partial class TblUniImagenes
    {
        public int IdImagen { get; set; }
        public string UniNumEco { get; set; }
        public string Imagen { get; set; }
        public string Descripcion { get; set; }

        public virtual TblUnidades UniNumEcoNavigation { get; set; }
    }
}
