using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Mentoring.Models
{
    public partial class Gender
    {
        public Gender()
        {
            InverseGenderGender = new HashSet<Gender>();
            ReportViewerGenders = new HashSet<ReportViewerGender>();
            Respondents = new HashSet<Respondent>();
        }

        public int GenderId { get; set; }
        public string Description { get; set; }
        public int? GenderGenderId { get; set; }

        public virtual Gender GenderGender { get; set; }
        public virtual ICollection<Gender> InverseGenderGender { get; set; }
        public virtual ICollection<ReportViewerGender> ReportViewerGenders { get; set; }
        public virtual ICollection<Respondent> Respondents { get; set; }
    }
}
