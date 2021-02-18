using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Mentoring.Models
{
    public partial class Onaemployee
    {
        public Guid Id { get; set; }
        public int WaveId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int? AreaId { get; set; }
        public int? CountryId { get; set; }
        public int? FunctionId { get; set; }
        public int? SubFunctionId { get; set; }
        public int? GenerationId { get; set; }
        public int? GenderId { get; set; }
        public int? JobLevelId { get; set; }
        public int? TernureId { get; set; }
        public int? ExecutiveId { get; set; }
        public int? GeographicRegionId { get; set; }
        public int? BuregionId { get; set; }
    }
}
