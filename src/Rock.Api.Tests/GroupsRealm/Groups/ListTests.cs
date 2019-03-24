using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Shouldly;

namespace Rock.Api.Tests.Groups {
    [TestFixture]
    public class ListTests : Base {
        [Test]
        public void groups_list_tests_get_by_family_id() {
            var results = this.RockClient.GroupRealm.Groups.List();
            results.Data.Count().ShouldBeGreaterThan(0);
        }

        [Test]
        public void groups_list_get_families_by_person() {
            var results = this.RockClient.GroupRealm.Groups.GetFamilies(122);
            results.Data.Count().ShouldBeGreaterThan(0);
        }
    }
}
