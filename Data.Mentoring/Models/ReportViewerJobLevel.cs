using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Mentoring.Models
{
    public partial class ReportViewerJobLevel
    {
        public string UserId { get; set; }
        public int LevelId { get; set; }

        public virtual Level Level { get; set; }
        public virtual ReportViewer User { get; set; }
    }
}
