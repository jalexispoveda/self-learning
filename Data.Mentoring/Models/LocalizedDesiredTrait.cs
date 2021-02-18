using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Mentoring.Models
{
    public partial class LocalizedDesiredTrait
    {
        public Guid LocalizedDesiredTraitsId { get; set; }
        public int DesiredTraitId { get; set; }
        public string Locale { get; set; }
        public string Description { get; set; }

        public virtual CompanyDesiredTrait DesiredTrait { get; set; }
    }
}
