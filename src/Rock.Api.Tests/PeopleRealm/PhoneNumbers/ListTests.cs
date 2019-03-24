using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Shouldly;

namespace Rock.Api.Tests.PhoneNumbers {
    [TestFixture]
    public class ListTests : Base {
        [Test]
        public void phone_list_tests_return_phone_numbers() {
            var results = this.RockClient.PeopleRealm.PhoneNumbers.List();
            results.Data.Count().ShouldBeGreaterThan(0);
        }
    }
}
