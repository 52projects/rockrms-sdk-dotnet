using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Shouldly;

namespace Rock.Api.Tests.PeopleRealm.People {
    [TestFixture]
    public class LoginTests : Base {
        [Test]
        public void user_logins_successful_login() {
            var person = this.RockClient.PeopleRealm.People.Login("admin", "Password");
            person.IsSuccessful.ShouldBe(true);
        }

        [Test]
        public void user_logins_unsuccessful_login() {
            var person = this.RockClient.PeopleRealm.People.Login("admin", "Pasdfdfdsword");
            person.ShouldBe(null);
        }
    }
}
