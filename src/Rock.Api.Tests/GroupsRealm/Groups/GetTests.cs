using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Shouldly;

namespace Rock.Api.Tests.GroupsRealm.GroupMembers {
    [TestFixture]
    public class GetTests : Base {
        [Test]
        public void group_get_tests_get_by_grou_id() {
            var results = this.RockClient.GroupRealm.Groups.Get("2");
            results.ShouldNotBe(null);
        }
    }
}
