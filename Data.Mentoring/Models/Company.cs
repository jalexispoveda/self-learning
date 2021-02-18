using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Mentoring.Models
{
    public partial class Company
    {
        public Company()
        {
            CompanyDesiredTraits = new HashSet<CompanyDesiredTrait>();
            CompanyExecutives = new HashSet<CompanyExecutive>();
            CompanyFunctions = new HashSet<CompanyFunction>();
            CompanyInvitations = new HashSet<CompanyInvitation>();
            CompanyLanguages = new HashSet<CompanyLanguage>();
            CompanyLevels = new HashSet<CompanyLevel>();
            CompanyTraits = new HashSet<CompanyTrait>();
            CompanyValues = new HashSet<CompanyValue>();
            ConsultantCompanies = new HashSet<ConsultantCompany>();
            ReportViewers = new HashSet<ReportViewer>();
            Respondents = new HashSet<Respondent>();
            Waves = new HashSet<Wave>();
        }

        public int CompanyId { get; set; }
        public string CompanyName { get; set; }
        public string CompanyLogoUrl { get; set; }
        public string RouteValue { get; set; }
        public int? IndustryId { get; set; }
        public int? AreaId { get; set; }
        public int? CountryId { get; set; }
        public int? RevenueRangeId { get; set; }
        public int? EmployeeRangeId { get; set; }
        public bool? CustomFunctions { get; set; }
        public double? GrossMargin { get; set; }
        public long? CompanySize { get; set; }
        public bool IsBenchmark { get; set; }
        public bool? CustomLevels { get; set; }
        public bool? EnableExecutives { get; set; }
        public bool? CustomExecutive { get; set; }
        public string ExecutiveName { get; set; }
        public bool? EnableGeographicRegion { get; set; }
        public int? GeographicRegionId { get; set; }
        public bool? EnableBuregion { get; set; }
        public bool UseDataForBenchmark { get; set; }
        public bool CustomTraitsDescriptions { get; set; }
        public bool HasPositivityQuestion { get; set; }

        public virtual Area Area { get; set; }
        public virtual Country Country { get; set; }
        public virtual EmployeeRange EmployeeRange { get; set; }
        public virtual GeographicRegion GeographicRegion { get; set; }
        public virtual Industry Industry { get; set; }
        public virtual RevenueRange RevenueRange { get; set; }
        public virtual ICollection<CompanyDesiredTrait> CompanyDesiredTraits { get; set; }
        public virtual ICollection<CompanyExecutive> CompanyExecutives { get; set; }
        public virtual ICollection<CompanyFunction> CompanyFunctions { get; set; }
        public virtual ICollection<CompanyInvitation> CompanyInvitations { get; set; }
        public virtual ICollection<CompanyLanguage> CompanyLanguages { get; set; }
        public virtual ICollection<CompanyLevel> CompanyLevels { get; set; }
        public virtual ICollection<CompanyTrait> CompanyTraits { get; set; }
        public virtual ICollection<CompanyValue> CompanyValues { get; set; }
        public virtual ICollection<ConsultantCompany> ConsultantCompanies { get; set; }
        public virtual ICollection<ReportViewer> ReportViewers { get; set; }
        public virtual ICollection<Respondent> Respondents { get; set; }
        public virtual ICollection<Wave> Waves { get; set; }
    }
}
