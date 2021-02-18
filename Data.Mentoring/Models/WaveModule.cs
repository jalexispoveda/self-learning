using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Mentoring.Models
{
    public partial class WaveModule
    {
        public int WaveModuleId { get; set; }
        public int? WaveId { get; set; }
        public int? Rank1 { get; set; }
        public int? Rank2 { get; set; }
        public int? Rank3 { get; set; }
        public int? Rank4 { get; set; }
    }
}
