
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rock.Api.Model;

namespace Rock.Api.Groups.Model {
    public class GroupType : ApiModel {
        public bool IsSystem { get; set; }

        public int GroupTypeId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public int Order { get; set; }

        public int? MaxCount { get; set; }

        public int? MinCount { get; set; }

        public bool IsLeader { get; set; }

        public bool ReceiveRequirementsNotifications { get; set; }

        public bool CanView { get; set; }

        public bool CanEdit { get; set; }

        public bool CanManageMembers { get; set; }
    }
}
