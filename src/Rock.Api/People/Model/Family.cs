using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rock.Api.Model;

namespace Rock.Api.People.Model {
    public class Family : ApiModel {
        public Family() {
            FamilyMembers = new List<FamilyMember>();
        }

        public string Name { get; set; }

        public List<FamilyMember> FamilyMembers { get; set; }

        public Location HomeLocation { get; set; }

        public PhoneNumber MainPhone { get; set; }

    }
}
