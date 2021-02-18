using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Mentoring.Models
{
    public partial class SurveyAnswer
    {
        public Guid Id { get; set; }
        public int WaveId { get; set; }
        public string UserId { get; set; }
        public Guid QuestionId { get; set; }
        public string Answer { get; set; }
        public bool? Na { get; set; }

        public virtual SurveyQuestion Question { get; set; }
        public virtual AspNetUser User { get; set; }
        public virtual Wave Wave { get; set; }
    }
}
