using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Mentoring.Models
{
    public partial class WaveUser
    {
        public int WaveId { get; set; }
        public string UserId { get; set; }
        public bool IsReportViewer { get; set; }
        public bool? ConsentGiven { get; set; }
        public DateTimeOffset? ConsentGivenDate { get; set; }
        public string LastAccessToken { get; set; }

        public virtual AspNetUser User { get; set; }
        public virtual Wave Wave { get; set; }
    }
}
