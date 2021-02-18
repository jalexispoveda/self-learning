using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Mentoring.Models
{
    public partial class LocalizedString
    {
        public string Key { get; set; }
        public string Locale { get; set; }
        public string Value { get; set; }
        public string Module { get; set; }
    }
}
