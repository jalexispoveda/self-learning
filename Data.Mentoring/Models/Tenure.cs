using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Mentoring.Models
{
    public partial class Tenure
    {
        public Tenure()
        {
            ReportViewerTenures = new HashSet<ReportViewerTenure>();
            Respondents = new HashSet<Respondent>();
        }

        public int TenureId { get; set; }
        public string Description { get; set; }

        public virtual ICollection<ReportViewerTenure> ReportViewerTenures { get; set; }
        public virtual ICollection<Respondent> Respondents { get; set; }
    }
}
