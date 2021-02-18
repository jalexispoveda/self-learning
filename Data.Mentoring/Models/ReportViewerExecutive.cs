using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Mentoring.Models
{
    public partial class ReportViewerExecutive
    {
        public string UserId { get; set; }
        public int ExecutiveId { get; set; }

        public virtual Executive Executive { get; set; }
        public virtual ReportViewer User { get; set; }
    }
}
