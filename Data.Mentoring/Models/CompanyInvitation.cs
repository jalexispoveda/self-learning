using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Mentoring.Models
{
    public partial class CompanyInvitation
    {
        public int CompanyInvitationId { get; set; }
        public int CompanyId { get; set; }
        public string InvitationMessage { get; set; }
        public string UserId { get; set; }
        public DateTimeOffset UpdateDateTime { get; set; }

        public virtual Company Company { get; set; }
        public virtual AspNetUser User { get; set; }
    }
}
