using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Mentoring.Models
{
    public partial class ScriptsHistory
    {
        public string ScriptNameId { get; set; }
        public string DatabaseName { get; set; }
        public DateTimeOffset Date { get; set; }
    }
}
