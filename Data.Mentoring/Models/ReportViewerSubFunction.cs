using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Mentoring.Models
{
    public partial class ReportViewerSubFunction
    {
        public string UserId { get; set; }
        public int SubFunctionId { get; set; }

        public virtual CompanySubFunction SubFunction { get; set; }
        public virtual ReportViewer User { get; set; }
    }
}
