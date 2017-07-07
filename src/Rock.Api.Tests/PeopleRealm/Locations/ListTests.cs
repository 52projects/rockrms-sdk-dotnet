using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Shouldly;

namespace Rock.Api.Tests.Locations {
    public class ListTests : Base {
        [Test]
        public void locations_list_tests_return_locations() {
            var results = this.RockClient.PeopleRealm.Locations.List();
            results.Count().ShouldBeGreaterThan(0);
        }
    }
}
