using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Mentoring.Models
{
    public partial class Country
    {
        public Country()
        {
            Companies = new HashSet<Company>();
            ReportViewerCountries = new HashSet<ReportViewerCountry>();
            Respondents = new HashSet<Respondent>();
        }

        public int CountryId { get; set; }
        public int AreaId { get; set; }
        public string Description { get; set; }

        public virtual Area Area { get; set; }
        public virtual ICollection<Company> Companies { get; set; }
        public virtual ICollection<ReportViewerCountry> ReportViewerCountries { get; set; }
        public virtual ICollection<Respondent> Respondents { get; set; }
    }
}
