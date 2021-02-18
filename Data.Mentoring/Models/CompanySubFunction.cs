using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Mentoring.Models
{
    public partial class CompanySubFunction
    {
        public CompanySubFunction()
        {
            ReportViewerSubFunctions = new HashSet<ReportViewerSubFunction>();
            Respondents = new HashSet<Respondent>();
        }

        public int CompanySubFunctionId { get; set; }
        public int CompanyFunctionId { get; set; }
        public string Description { get; set; }
        public int Order { get; set; }

        public virtual CompanyFunction CompanyFunction { get; set; }
        public virtual ICollection<ReportViewerSubFunction> ReportViewerSubFunctions { get; set; }
        public virtual ICollection<Respondent> Respondents { get; set; }
    }
}
