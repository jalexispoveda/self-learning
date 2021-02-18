using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Mentoring.Models
{
    public partial class Password
    {
        public int PasswordId { get; set; }
        public string UserId { get; set; }
        public string PasswordHash { get; set; }
        public DateTimeOffset CreatedDate { get; set; }

        public virtual AspNetUser User { get; set; }
    }
}
