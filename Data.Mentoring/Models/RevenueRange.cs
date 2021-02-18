using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Mentoring.Models
{
    public partial class RevenueRange
    {
        public RevenueRange()
        {
            Companies = new HashSet<Company>();
        }

        public int RevenueRangeId { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Company> Companies { get; set; }
    }
}
