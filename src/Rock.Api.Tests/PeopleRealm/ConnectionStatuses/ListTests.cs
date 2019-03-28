using NUnit.Framework;
using Shouldly;

namespace Rock.Api.Tests.ConnectionStatuses {
    public class ListTests : Base {
        [Test]
        public void connection_statues_list_all() {
            var results = this.RockClient.PeopleRealm.ConnectionStatuses.FindAll();
            results.Data.Items.Count.ShouldBeGreaterThan(0);
        }
    }
}
