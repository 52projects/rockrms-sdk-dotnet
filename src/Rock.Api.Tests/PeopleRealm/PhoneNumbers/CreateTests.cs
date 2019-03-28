using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Shouldly;
using Rock.Api.People.Model;


namespace Rock.Api.Tests.PhoneNumbers {
    [TestFixture]
    public class CreateTests : Base {
        [Test]
        public void phonenumbers_create_tests_create_phone_for_person() {
            var results = this.RockClient.PeopleRealm.People.FindByEmail("chadmeyer@52projectsllc.com");
            var person = results.Data.Items[0];

            var phone = new PhoneNumber {
                Number = "6822091225",
                PersonId = person.Id.Value,
                IsSystem = false
            };

            var outPutXml = string.Empty;
            var result = this.RockClient.PeopleRealm.PhoneNumbers.Create(phone, out outPutXml);
            result.Data.ShouldBeGreaterThan(0);
        }
    }
}
