using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Mentoring.Models
{
    public partial class SurveyQuestion
    {
        public SurveyQuestion()
        {
            LocalizedQuestions = new HashSet<LocalizedQuestion>();
            SurveyAnswers = new HashSet<SurveyAnswer>();
        }

        public Guid Id { get; set; }
        public int WaveId { get; set; }
        public int Type { get; set; }
        public string QuestionView { get; set; }
        public string Question { get; set; }
        public float? Order { get; set; }
        public float? TemplateOrder { get; set; }
        public int? ResponsesAllowed { get; set; }
        public bool? IsEnabled { get; set; }

        public virtual ICollection<LocalizedQuestion> LocalizedQuestions { get; set; }
        public virtual ICollection<SurveyAnswer> SurveyAnswers { get; set; }
    }
}
