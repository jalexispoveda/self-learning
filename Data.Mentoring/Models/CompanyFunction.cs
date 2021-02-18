using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Mentoring.Models
{
    public partial class CompanyFunction
    {
        public CompanyFunction()
        {
            CompanySubFunctions = new HashSet<CompanySubFunction>();
        }

        public int CompanyFunctionId { get; set; }
        public int CompanyId { get; set; }
        public int FunctionId { get; set; }
        public string Description { get; set; }
        public int Order { get; set; }

        public virtual Company Company { get; set; }
        public virtual Function Function { get; set; }
        public virtual ICollection<CompanySubFunction> CompanySubFunctions { get; set; }
    }
}
