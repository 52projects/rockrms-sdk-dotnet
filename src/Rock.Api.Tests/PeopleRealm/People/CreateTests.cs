using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Shouldly;
using Rock.Api.People.Model;

namespace Rock.Api.Tests.PeopleRealm.People {
    [TestFixture]
    public class CreateTests : Base {
        [Test]
        public void create_tests_create_person() {
            var person = new Person {
                FirstName = "Chad",
                LastName = "Meyer",
                Email = "chadmeyer@52projectsllc.com",
                Gender = Api.People.Enum.Gender.Male,
                ConnectionStatusValueId = 65
            };
            var outPutXml = string.Empty;
            var result = this.RockClient.PeopleRealm.People.Create(person, out outPutXml);
            result.Data.ShouldBeGreaterThan(0);
        }
    }
}
