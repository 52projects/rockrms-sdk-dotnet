﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Shouldly;

namespace Rock.Api.Tests.FinancialRealm.Pledges {
    [TestFixture]
    public class ListTests : Base {
        [Test]
        public void financial_pledges_get_all() {
            var results = this.RockClient.FinancialRealm.Pledges.List();
            results.Data.Count().ShouldBeGreaterThan(0);
        }
    }
}
