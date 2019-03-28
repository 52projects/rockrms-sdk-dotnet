using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rock.Api.Model;

namespace Rock.Api.Groups.Model {
    public class GroupMember : ApiModel {
        public int GroupId { get; set; }

        public int PersonId { get; set; }

        public int GroupRoleId { get; set; }

        public string Note { get; set; }

        public int GroupMemberStatus { get; set; }

        public int? GuestCount { get; set; }

        public DateTime? DateTimeAdded { get; set; }

        public bool IsNotified { get; set; }

        public int? GroupOrder { get; set; }

        public DateTime? InactiveDateTime { get; set; }

        public bool IsArchived { get; set; }

        public DateTime? ArchivedDateTime { get; set; }
    }
}
