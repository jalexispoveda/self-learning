using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Mentoring.Models
{
    public partial class Area
    {
        public Area()
        {
            Companies = new HashSet<Company>();
            Countries = new HashSet<Country>();
            ReportViewerAreas = new HashSet<ReportViewerArea>();
            Respondents = new HashSet<Respondent>();
        }

        public int AreaId { get; set; }
        public string Description { get; set; }
        public int? CompanyId { get; set; }

        public virtual ICollection<Company> Companies { get; set; }
        public virtual ICollection<Country> Countries { get; set; }
        public virtual ICollection<ReportViewerArea> ReportViewerAreas { get; set; }
        public virtual ICollection<Respondent> Respondents { get; set; }
    }
}
