using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Mentoring.Models
{
    public partial class ReportViewer
    {
        public ReportViewer()
        {
            ReportViewerAreas = new HashSet<ReportViewerArea>();
            ReportViewerBuregions = new HashSet<ReportViewerBuregion>();
            ReportViewerCountries = new HashSet<ReportViewerCountry>();
            ReportViewerExecutives = new HashSet<ReportViewerExecutive>();
            ReportViewerFunctions = new HashSet<ReportViewerFunction>();
            ReportViewerGenders = new HashSet<ReportViewerGender>();
            ReportViewerGenerations = new HashSet<ReportViewerGeneration>();
            ReportViewerGeographicRegions = new HashSet<ReportViewerGeographicRegion>();
            ReportViewerJobLevels = new HashSet<ReportViewerJobLevel>();
            ReportViewerPulseReports = new HashSet<ReportViewerPulseReport>();
            ReportViewerReports = new HashSet<ReportViewerReport>();
            ReportViewerSubFunctions = new HashSet<ReportViewerSubFunction>();
            ReportViewerTenures = new HashSet<ReportViewerTenure>();
            ReportViewerWaves = new HashSet<ReportViewerWave>();
        }

        public int? CompanyId { get; set; }
        public string UserId { get; set; }

        public virtual Company Company { get; set; }
        public virtual AspNetUser User { get; set; }
        public virtual ICollection<ReportViewerArea> ReportViewerAreas { get; set; }
        public virtual ICollection<ReportViewerBuregion> ReportViewerBuregions { get; set; }
        public virtual ICollection<ReportViewerCountry> ReportViewerCountries { get; set; }
        public virtual ICollection<ReportViewerExecutive> ReportViewerExecutives { get; set; }
        public virtual ICollection<ReportViewerFunction> ReportViewerFunctions { get; set; }
        public virtual ICollection<ReportViewerGender> ReportViewerGenders { get; set; }
        public virtual ICollection<ReportViewerGeneration> ReportViewerGenerations { get; set; }
        public virtual ICollection<ReportViewerGeographicRegion> ReportViewerGeographicRegions { get; set; }
        public virtual ICollection<ReportViewerJobLevel> ReportViewerJobLevels { get; set; }
        public virtual ICollection<ReportViewerPulseReport> ReportViewerPulseReports { get; set; }
        public virtual ICollection<ReportViewerReport> ReportViewerReports { get; set; }
        public virtual ICollection<ReportViewerSubFunction> ReportViewerSubFunctions { get; set; }
        public virtual ICollection<ReportViewerTenure> ReportViewerTenures { get; set; }
        public virtual ICollection<ReportViewerWave> ReportViewerWaves { get; set; }
    }
}
