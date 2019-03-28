using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Shouldly;

namespace Rock.Api.Tests.People {
    [TestFixture]
    public class GetTests : Base {
        [Test]
        public void people_get_tests_return_specific_person() {
            var people = this.RockClient.PeopleRealm.People.List();
            var person = this.RockClient.PeopleRealm.People.Get(people.Data[0].Id.ToString());
            person.Data.Id.ShouldBe(people.Data[0].Id);
        }

        [Test]
        public void people_get_family_by_family_id() {
            var results = this.RockClient.PeopleRealm.People.FindByEmail("ted@rocksolidchurchdemo.com");
            var person = results.Data.Items[0];

            var familyResults = RockClient.PeopleRealm.People.GetFamily(person.PrimaryFamilyId.Value);
            results.ShouldNotBe(null);
        }
    }
}
