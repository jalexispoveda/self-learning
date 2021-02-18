using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Mentoring.Models
{
    public partial class Generation
    {
        public Generation()
        {
            ReportViewerGenerations = new HashSet<ReportViewerGeneration>();
            Respondents = new HashSet<Respondent>();
        }

        public int GenerationId { get; set; }
        public string Description { get; set; }

        public virtual ICollection<ReportViewerGeneration> ReportViewerGenerations { get; set; }
        public virtual ICollection<Respondent> Respondents { get; set; }
    }
}
