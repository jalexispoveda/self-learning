using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Mentoring.Models
{
    public partial class ReportViewerWave
    {
        public string UserId { get; set; }
        public int WaveId { get; set; }

        public virtual ReportViewer User { get; set; }
        public virtual Wave Wave { get; set; }
    }
}
