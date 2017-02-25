using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Shouldly;
using Rock.Api.People.QueryObject;
using Rock.Api.People.Model;

namespace Rock.Api.Tests.People {
    [TestFixture]
    public class SearchTests : Base {
        [Test]
        public void people_search_tests_search_by_name_include_details() {
            var qo = new PersonQO();
            qo.Name = "cha mey";
            var results = this.RockClient.PeopleRealm.People.Search<List<Person>>(qo);
            results.Count().ShouldBeGreaterThan(0);
        }
    }
}
