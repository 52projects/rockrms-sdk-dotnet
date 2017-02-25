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
            var results = this.RockClient.PeopleRealm.People.Get("121");
            results.Id.ShouldBe(121);
        }

        [Test]
        public void people_get_tests_return_specific_person_by_email() {
            var results = this.RockClient.PeopleRealm.People.GetByEmail("chadmeyer@52projectsllc.com");
            results.Id.ShouldBe(121);
        }
    }
}
