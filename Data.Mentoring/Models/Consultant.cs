using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Mentoring.Models
{
    public partial class Consultant
    {
        public Consultant()
        {
            ConsultantCompanies = new HashSet<ConsultantCompany>();
        }

        public int? ServiceLineId { get; set; }
        public int? SubServiceLineId { get; set; }
        public int? LevelId { get; set; }
        public string UserId { get; set; }

        public virtual Level Level { get; set; }
        public virtual ServiceLine ServiceLine { get; set; }
        public virtual SubServiceLine SubServiceLine { get; set; }
        public virtual AspNetUser User { get; set; }
        public virtual ICollection<ConsultantCompany> ConsultantCompanies { get; set; }
    }
}
