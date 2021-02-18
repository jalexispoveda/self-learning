using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Mentoring.Models
{
    public partial class Executive
    {
        public Executive()
        {
            CompanyExecutives = new HashSet<CompanyExecutive>();
            ReportViewerExecutives = new HashSet<ReportViewerExecutive>();
            Respondents = new HashSet<Respondent>();
        }

        public int ExecutiveId { get; set; }
        public string Description { get; set; }

        public virtual ICollection<CompanyExecutive> CompanyExecutives { get; set; }
        public virtual ICollection<ReportViewerExecutive> ReportViewerExecutives { get; set; }
        public virtual ICollection<Respondent> Respondents { get; set; }
    }
}
