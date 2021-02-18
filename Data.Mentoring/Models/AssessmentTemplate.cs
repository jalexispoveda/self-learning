using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Mentoring.Models
{
    public partial class AssessmentTemplate
    {
        public AssessmentTemplate()
        {
            AssessmentQuestions = new HashSet<AssessmentQuestion>();
        }

        public int AssessmentTemplateId { get; set; }
        public string Description { get; set; }

        public virtual ICollection<AssessmentQuestion> AssessmentQuestions { get; set; }
    }
}
