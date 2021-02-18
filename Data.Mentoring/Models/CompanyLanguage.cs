using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Mentoring.Models
{
    public partial class CompanyLanguage
    {
        public int CompanyId { get; set; }
        public string Locale { get; set; }
        public bool? IsEnabled { get; set; }

        public virtual Company Company { get; set; }
    }
}
