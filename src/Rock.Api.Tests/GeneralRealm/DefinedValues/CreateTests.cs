using NUnit.Framework;
using Shouldly;
using Rock.Api.General.Model;
using Rock.Api.General.Enum;

namespace Rock.Api.Tests.General {
    [TestFixture]
    public class CreateTests : Base {
        [Test]
        public void general_list_create_defined_value() {
            var definedValue = new DefinedValue {
                DefinedTypeId = (int)SystemDefinedType.TransactionSource,
                IsSystem = false,
                IsActive = true,
                Description = "Transactions that originate through the api test bed",
                Value = "Api Test",
            };

            var results = this.RockClient.GeneralRealm.DefinedValues.Create(definedValue);
            results.Data.ShouldBeGreaterThan(0);
        }
    }
}
