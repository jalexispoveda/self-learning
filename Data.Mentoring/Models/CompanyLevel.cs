using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Mentoring.Models
{
    public partial class CompanyLevel
    {
        public int CompanyId { get; set; }
        public int LevelId { get; set; }
        public string Description { get; set; }
        public int CompanyLevelId { get; set; }
        public int Order { get; set; }

        public virtual Company Company { get; set; }
        public virtual Level Level { get; set; }
    }
}
