using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Shouldly;
using Rock.Api.Groups.Model;

namespace Rock.Api.Tests.PeopleRealm.Families {
    public class GetTests : Base {

        [Test]
        public void families_get_family_by_family_id() {
            var results = this.RockClient.PeopleRealm.People.FindByEmail("chadmeyer@me.com");
            var person = results.Data.Items[0];

            var familyResults = RockClient.PeopleRealm.Families.Get(person.PrimaryFamilyId.Value.ToString());
            var groupResults = RockClient.GroupRealm.Groups.Get(person.PrimaryFamilyId.Value.ToString());
            results.ShouldNotBe(null);
        }
    }
}
