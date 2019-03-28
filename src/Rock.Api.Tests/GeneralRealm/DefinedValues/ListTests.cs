using NUnit.Framework;
using Shouldly;

namespace Rock.Api.Tests.General {
    [TestFixture]
    public class ListTests : Base {
        [Test]
        public void general_list_get_connection_statuses() {
            var results = this.RockClient.GeneralRealm.DefinedValues.FindByType(Api.General.Enum.SystemDefinedType.ConnectionStatus);
            results.Data.Items.Count.ShouldBeGreaterThan(0);
        }
    }
}
