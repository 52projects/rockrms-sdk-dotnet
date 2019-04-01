using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Shouldly;
using Rock.Api.Financial.Model;

namespace Rock.Api.Tests.FinancialRealm.Accounts {
    [TestFixture]
    public class CreateTests : Base {
        [Test]
        public void financial_accounts_create() {
            var account = new Account {
                IsActive = true,
                IsPublic = false,
                StartDate = DateTime.UtcNow,
                EndDate = DateTime.UtcNow.AddDays(30),
                Name = "Israel 2019",
                ParentAccountId = 3,
                Description = "The description"
            };

            var results = this.RockClient.FinancialRealm.Accounts.Create(account);
            results.Data.ShouldBeGreaterThan(0);
        }
    }
}
