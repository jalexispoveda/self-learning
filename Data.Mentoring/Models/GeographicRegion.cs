using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Mentoring.Models
{
    public partial class GeographicRegion
    {
        public GeographicRegion()
        {
            Companies = new HashSet<Company>();
            ReportViewerGeographicRegions = new HashSet<ReportViewerGeographicRegion>();
            Respondents = new HashSet<Respondent>();
        }

        public int GeographicRegionId { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Company> Companies { get; set; }
        public virtual ICollection<ReportViewerGeographicRegion> ReportViewerGeographicRegions { get; set; }
        public virtual ICollection<Respondent> Respondents { get; set; }
    }
}
