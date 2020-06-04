using System;
using System.Collections.Generic;

namespace PRO_001.Models
{
    public partial class AdmonTelMoviles
    {
        public int IdTelMovil { get; set; }
        public int IdPersonalAdmon { get; set; }
        public string NoMovil { get; set; }
        public string Status { get; set; }

        public virtual RhPersonalAdmon IdPersonalAdmonNavigation { get; set; }
    }
}
