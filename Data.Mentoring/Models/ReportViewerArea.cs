using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Mentoring.Models
{
    public partial class ReportViewerArea
    {
        public string UserId { get; set; }
        public int AreaId { get; set; }

        public virtual Area Area { get; set; }
        public virtual ReportViewer User { get; set; }
    }
}
