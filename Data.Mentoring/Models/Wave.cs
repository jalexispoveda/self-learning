using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Mentoring.Models
{
    public partial class Wave
    {
        public Wave()
        {
            ReportViewerWaves = new HashSet<ReportViewerWave>();
            SurveyAnswers = new HashSet<SurveyAnswer>();
            SurveyData = new HashSet<SurveyData>();
            WaveUsers = new HashSet<WaveUser>();
        }

        public int WaveId { get; set; }
        public int CompanyId { get; set; }
        public string Description { get; set; }
        public int AssessmentTemplateId { get; set; }
        public bool Published { get; set; }
        public bool RiskModule { get; set; }
        public string WaveTag { get; set; }
        public bool IsClosed { get; set; }
        public bool IsEthicsAndComplaince { get; set; }
        public int? PulseId { get; set; }

        public virtual Company Company { get; set; }
        public virtual ICollection<ReportViewerWave> ReportViewerWaves { get; set; }
        public virtual ICollection<SurveyAnswer> SurveyAnswers { get; set; }
        public virtual ICollection<SurveyData> SurveyData { get; set; }
        public virtual ICollection<WaveUser> WaveUsers { get; set; }
    }
}
