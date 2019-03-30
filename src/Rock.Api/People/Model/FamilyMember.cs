using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rock.Api.Groups.Model;
using Rock.Api.Model;

namespace Rock.Api.People.Model {
    public class FamilyMember : GroupMember {
        public GroupRole GroupRole { get; set; }

        public Person Person { get; set; }

        public PhoneNumber MainPhone { get; set; }
    }
}
