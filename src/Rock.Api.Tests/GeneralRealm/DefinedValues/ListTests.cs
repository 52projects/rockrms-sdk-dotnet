using NUnit.Framework;
using Shouldly;
using Rock.Api.General.Model;

namespace Rock.Api.Tests.General {
    [TestFixture]
    public class ListTests : Base {
        [Test]
        public void general_list_get_connection_statuses() {
            var results = this.RockClient.GeneralRealm.DefinedValues.FindByType(Api.General.Enum.SystemDefinedType.ConnectionStatus);
            results.Data.Items.Count.ShouldBeGreaterThan(0);
        }

        [Test]
        public void general_list_get_backgroundchecktypes_with_attributes() {
            var results = this.RockClient.GeneralRealm.DefinedValues.FindByType(Api.General.Enum.SystemDefinedType.BackgroundCheckTypes, true);
            results.Data.Items.Count.ShouldBeGreaterThan(0);
        }
    }
}
