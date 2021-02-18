using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Mentoring.Models
{
    public partial class Level
    {
        public Level()
        {
            CompanyLevels = new HashSet<CompanyLevel>();
            Consultants = new HashSet<Consultant>();
            ReportViewerJobLevels = new HashSet<ReportViewerJobLevel>();
            Respondents = new HashSet<Respondent>();
        }

        public int LevelId { get; set; }
        public string Description { get; set; }

        public virtual ICollection<CompanyLevel> CompanyLevels { get; set; }
        public virtual ICollection<Consultant> Consultants { get; set; }
        public virtual ICollection<ReportViewerJobLevel> ReportViewerJobLevels { get; set; }
        public virtual ICollection<Respondent> Respondents { get; set; }
    }
}
