using System;
using System.Collections.Generic;

namespace PRO_001.Models
{
    public partial class AdmonPerfiles
    {
        public AdmonPerfiles()
        {
            RhPersonalAdmon = new HashSet<RhPersonalAdmon>();
        }

        public int IdPerfil { get; set; }
        public int IdDepartamento { get; set; }
        public string NombrePerfil { get; set; }
        public string Status { get; set; }

        public virtual AdmonDepartamentos IdDepartamentoNavigation { get; set; }
        public virtual ICollection<RhPersonalAdmon> RhPersonalAdmon { get; set; }
    }
}
