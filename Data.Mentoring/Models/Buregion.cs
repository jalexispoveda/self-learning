using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Mentoring.Models
{
    public partial class Buregion
    {
        public Buregion()
        {
            ReportViewerBuregions = new HashSet<ReportViewerBuregion>();
            Respondents = new HashSet<Respondent>();
        }

        public int BuregionId { get; set; }
        public string Description { get; set; }

        public virtual ICollection<ReportViewerBuregion> ReportViewerBuregions { get; set; }
        public virtual ICollection<Respondent> Respondents { get; set; }
    }
}
