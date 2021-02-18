using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Mentoring.Models
{
    public partial class SubServiceLine
    {
        public SubServiceLine()
        {
            Consultants = new HashSet<Consultant>();
        }

        public int SubServiceLineId { get; set; }
        public int? ServiceLineId { get; set; }
        public string Description { get; set; }

        public virtual ServiceLine ServiceLine { get; set; }
        public virtual ICollection<Consultant> Consultants { get; set; }
    }
}
