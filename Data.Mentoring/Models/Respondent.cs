using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Mentoring.Models
{
    public partial class Respondent
    {
        public int CompanyId { get; set; }
        public DateTimeOffset? InvitationSent { get; set; }
        public int? AreaId { get; set; }
        public int? CountryId { get; set; }
        public int? FunctionId { get; set; }
        public int? CompanySubFunctionId { get; set; }
        public int? GenerationId { get; set; }
        public int? LevelId { get; set; }
        public int? TenureId { get; set; }
        public int? GenderId { get; set; }
        public string UserId { get; set; }
        public string WaveTag { get; set; }
        public int? ExecutiveId { get; set; }
        public int? GeographicRegionId { get; set; }
        public int? BuregionId { get; set; }
        public DateTimeOffset? ReminderSent { get; set; }

        public virtual Area Area { get; set; }
        public virtual Buregion Buregion { get; set; }
        public virtual Company Company { get; set; }
        public virtual CompanySubFunction CompanySubFunction { get; set; }
        public virtual Country Country { get; set; }
        public virtual Executive Executive { get; set; }
        public virtual Function Function { get; set; }
        public virtual Gender Gender { get; set; }
        public virtual Generation Generation { get; set; }
        public virtual GeographicRegion GeographicRegion { get; set; }
        public virtual Level Level { get; set; }
        public virtual Tenure Tenure { get; set; }
        public virtual AspNetUser User { get; set; }
    }
}
