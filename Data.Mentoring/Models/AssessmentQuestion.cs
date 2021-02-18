using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Mentoring.Models
{
    public partial class AssessmentQuestion
    {
        public int AssessmentTemplateId { get; set; }
        public string QuestionView { get; set; }
        public string QuestionTitle { get; set; }
        public float Order { get; set; }

        public virtual AssessmentTemplate AssessmentTemplate { get; set; }
    }
}
