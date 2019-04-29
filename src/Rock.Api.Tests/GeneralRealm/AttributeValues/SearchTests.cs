using NUnit.Framework;
using Shouldly;
using Rock.Api.General.Model;
using Rock.Api.General.Enum;

namespace Rock.Api.Tests.GeneralRealm.AttributeValues {
    [TestFixture]
    public class SearchTests : Base {
        [Test]
        public void general_attributes_get_by_entity_id() {
            var results = this.RockClient.GeneralRealm.AttributeValues.FindByEntityID(1213);
            results.IsSuccessful.ShouldBe(true);
        }
    }
}
