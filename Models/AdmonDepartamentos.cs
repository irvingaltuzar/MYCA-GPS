using System;
using System.Collections.Generic;

namespace PRO_001.Models
{
    public partial class AdmonDepartamentos
    {
        public AdmonDepartamentos()
        {
            AdmonPerfiles = new HashSet<AdmonPerfiles>();
        }

        public int IdDepartamento { get; set; }
        public string NombreDepto { get; set; }
        public string Status { get; set; }

        public virtual ICollection<AdmonPerfiles> AdmonPerfiles { get; set; }
    }
}
