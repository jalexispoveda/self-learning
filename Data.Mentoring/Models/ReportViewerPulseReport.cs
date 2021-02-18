using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Mentoring.Models
{
    public partial class ReportViewerPulseReport
    {
        public string UserId { get; set; }
        public int ReportId { get; set; }

        public virtual ReportViewer User { get; set; }
    }
}
