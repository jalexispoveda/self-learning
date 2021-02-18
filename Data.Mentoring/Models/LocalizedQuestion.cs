using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Mentoring.Models
{
    public partial class LocalizedQuestion
    {
        public Guid LocalizedQuestionId { get; set; }
        public Guid QuestionId { get; set; }
        public string Question { get; set; }
        public string Locale { get; set; }

        public virtual SurveyQuestion QuestionNavigation { get; set; }
    }
}
