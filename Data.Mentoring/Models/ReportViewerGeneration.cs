using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Mentoring.Models
{
    public partial class ReportViewerGeneration
    {
        public string UserId { get; set; }
        public int GenerationId { get; set; }

        public virtual Generation Generation { get; set; }
        public virtual ReportViewer User { get; set; }
    }
}
