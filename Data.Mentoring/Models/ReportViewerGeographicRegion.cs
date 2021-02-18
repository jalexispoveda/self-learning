using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Mentoring.Models
{
    public partial class ReportViewerGeographicRegion
    {
        public string UserId { get; set; }
        public int GeographicRegionId { get; set; }

        public virtual GeographicRegion GeographicRegion { get; set; }
        public virtual ReportViewer User { get; set; }
    }
}
