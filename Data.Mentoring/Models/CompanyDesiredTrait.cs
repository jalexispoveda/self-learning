using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Mentoring.Models
{
    public partial class CompanyDesiredTrait
    {
        public CompanyDesiredTrait()
        {
            LocalizedDesiredTraits = new HashSet<LocalizedDesiredTrait>();
        }

        public int DesiredTraitId { get; set; }
        public int CompanyId { get; set; }
        public string Description { get; set; }
        public decimal? BaselineValue { get; set; }
        public decimal? DesiredValue { get; set; }
        public bool? IsEnabled { get; set; }

        public virtual Company Company { get; set; }
        public virtual ICollection<LocalizedDesiredTrait> LocalizedDesiredTraits { get; set; }
    }
}
