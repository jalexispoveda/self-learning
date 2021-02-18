using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Mentoring.Models
{
    public partial class ServiceLine
    {
        public ServiceLine()
        {
            Consultants = new HashSet<Consultant>();
            SubServiceLines = new HashSet<SubServiceLine>();
        }

        public int ServiceLineId { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Consultant> Consultants { get; set; }
        public virtual ICollection<SubServiceLine> SubServiceLines { get; set; }
    }
}
