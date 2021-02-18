using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Mentoring.Models
{
    public partial class ReportViewerBuregion
    {
        public string UserId { get; set; }
        public int BuregionId { get; set; }

        public virtual Buregion Buregion { get; set; }
        public virtual ReportViewer User { get; set; }
    }
}
