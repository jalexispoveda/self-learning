using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Mentoring.Models
{
    public partial class CompanyValue
    {
        public int CompanyValueId { get; set; }
        public string Description { get; set; }
        public int CompanyId { get; set; }
        public int CompanyValueOrder { get; set; }
        public string Locale { get; set; }

        public virtual Company Company { get; set; }
    }
}
