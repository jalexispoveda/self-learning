using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Mentoring.Models
{
    public partial class Function
    {
        public Function()
        {
            CompanyFunctions = new HashSet<CompanyFunction>();
            ReportViewerFunctions = new HashSet<ReportViewerFunction>();
            Respondents = new HashSet<Respondent>();
        }

        public int FunctionId { get; set; }
        public string Description { get; set; }

        public virtual ICollection<CompanyFunction> CompanyFunctions { get; set; }
        public virtual ICollection<ReportViewerFunction> ReportViewerFunctions { get; set; }
        public virtual ICollection<Respondent> Respondents { get; set; }
    }
}
