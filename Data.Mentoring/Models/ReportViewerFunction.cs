using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Mentoring.Models
{
    public partial class ReportViewerFunction
    {
        public string UserId { get; set; }
        public int FunctionId { get; set; }

        public virtual Function Function { get; set; }
        public virtual ReportViewer User { get; set; }
    }
}
