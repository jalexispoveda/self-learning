using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Mentoring.Models
{
    public partial class CompanyExecutive
    {
        public int CompanyExecutiveId { get; set; }
        public int CompanyId { get; set; }
        public int ExecutiveId { get; set; }
        public string Description { get; set; }
        public int Order { get; set; }

        public virtual Company Company { get; set; }
        public virtual Executive Executive { get; set; }
    }
}
