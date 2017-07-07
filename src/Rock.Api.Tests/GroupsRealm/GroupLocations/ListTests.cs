using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Shouldly;

namespace Rock.Api.Tests.GroupsRealm.GroupLocations {
    [TestFixture]
    public class ListTests : Base {
        [Test]
        public void group_locations_list_tests_get_all() {
            var results = this.RockClient.GroupRealm.GroupLocations.List();
            results.Count().ShouldBeGreaterThan(0);
        }

        [Test]
        public void group_locations_list_tests_get_by_group_id() {
            var results = this.RockClient.GroupRealm.GroupLocations.GetByGroupID(4197);
            results.Items.Count().ShouldBeGreaterThan(0);
        }
    }
}
