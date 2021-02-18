using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Mentoring.Models
{
    public partial class EmployeeRange
    {
        public EmployeeRange()
        {
            Companies = new HashSet<Company>();
        }

        public int EmployeeRangeId { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Company> Companies { get; set; }
    }
}
