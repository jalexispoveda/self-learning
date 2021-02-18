using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Mentoring.Models
{
    public partial class ReportViewerTenure
    {
        public string UserId { get; set; }
        public int TenureId { get; set; }

        public virtual Tenure Tenure { get; set; }
        public virtual ReportViewer User { get; set; }
    }
}
