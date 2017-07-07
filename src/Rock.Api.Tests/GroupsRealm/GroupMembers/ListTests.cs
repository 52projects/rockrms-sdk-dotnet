using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Shouldly;

namespace Rock.Api.Tests.GroupsRealm.GroupMembers {
    [TestFixture]
    public class ListTests : Base {
        [Test]
        public void group_members_list_tests_get_all() {
            var results = this.RockClient.GroupRealm.GroupMembers.List();
            results.Count().ShouldBeGreaterThan(0);
        }
    }
}
