using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Mentoring.Models
{
    public partial class LocalizedTrait
    {
        public int LocalizedTraitsId { get; set; }
        public int CompanyTraitId { get; set; }
        public string Locale { get; set; }
        public string Trait { get; set; }
        public string Description { get; set; }

        public virtual CompanyTrait CompanyTrait { get; set; }
    }
}
