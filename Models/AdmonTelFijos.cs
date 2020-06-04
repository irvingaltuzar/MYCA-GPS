using System;
using System.Collections.Generic;

namespace PRO_001.Models
{
    public partial class AdmonTelFijos
    {
        public int IdTelefonoPersonal { get; set; }
        public int IdPersonalAdmon { get; set; }
        public string NoTelefono { get; set; }
        public string Status { get; set; }

        public virtual RhPersonalAdmon IdPersonalAdmonNavigation { get; set; }
    }
}
