using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Shouldly;

namespace Rock.Api.Tests.GroupsRealm.GroupMembers {
    [TestFixture]
    public class GetTests : Base {
        [Test]
        public void group_get_family_by_family_id() {
            var results = this.RockClient.PeopleRealm.People.FindByEmail("ted@rocksolidchurchdemo.com");
            var person = results.Data.Items[0];

            var familyResults = RockClient.GroupRealm.Groups.GetByFamilyID(person.PrimaryFamilyId.Value);
            results.ShouldNotBe(null);
        }
    }
}
