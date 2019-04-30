using NUnit.Framework;
using Shouldly;
using Rock.Api.General.Model;
using Rock.Api.General.Enum;

namespace Rock.Api.Tests.GeneralRealm.Attributes {
    [TestFixture]
    public class SearchTests : Base {
        [Test]
        public void general_attributes_get_by_entity_type_id() {
            var results = this.RockClient.GeneralRealm.Attributes.FindByEntityTypeID(EntityType.Person);
            results.IsSuccessful.ShouldBe(true);
        }
    }
}
