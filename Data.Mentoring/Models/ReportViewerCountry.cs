using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Mentoring.Models
{
    public partial class ReportViewerCountry
    {
        public string UserId { get; set; }
        public int CountryId { get; set; }

        public virtual Country Country { get; set; }
        public virtual ReportViewer User { get; set; }
    }
}
