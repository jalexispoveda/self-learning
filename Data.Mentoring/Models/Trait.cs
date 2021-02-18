using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Mentoring.Models
{
    public partial class Trait
    {
        public Trait()
        {
            CompanyTraits = new HashSet<CompanyTrait>();
        }

        public int TraitId { get; set; }
        public bool IsPositive { get; set; }
        public string Description { get; set; }
        public int? Rating { get; set; }
        public bool Default { get; set; }
        public bool? Active { get; set; }

        public virtual ICollection<CompanyTrait> CompanyTraits { get; set; }
    }
}
