using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Shouldly;

namespace Rock.Api.Tests.People {
    [TestFixture]
    public class ListTests : Base {
        [Test]
        public void people_list_tests_return_people() {
            var results = this.RockClient.PeopleRealm.People.List();
            results.Count().ShouldBeGreaterThan(0);
        }
    }
}
