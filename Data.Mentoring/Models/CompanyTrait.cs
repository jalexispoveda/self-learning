using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Mentoring.Models
{
    public partial class CompanyTrait
    {
        public CompanyTrait()
        {
            LocalizedTraits = new HashSet<LocalizedTrait>();
        }

        public int CompanyTraitId { get; set; }
        public int CompanyId { get; set; }
        public int? TraitId { get; set; }
        public string Description { get; set; }
        public bool IsPositive { get; set; }
        public int? Rating { get; set; }
        public bool IsDefault { get; set; }
        public bool? IsEnabled { get; set; }

        public virtual Company Company { get; set; }
        public virtual Trait Trait { get; set; }
        public virtual ICollection<LocalizedTrait> LocalizedTraits { get; set; }
    }
}
