using System;
using NUnit.Framework;
using Rock.Api.Financial.Model;
using Rock.Api.Financial.QueryObject;
using Shouldly;

namespace Rock.Api.Tests.FinancialRealm.Transactions {
    [TestFixture]
    public class SearchTests : Base {
        [Test]
        public void financial_transactions_search_modified_date() {
            var qo = new TransactionDetailQO {
                ModifiedDateTime = DateTime.UtcNow.AddDays(-14),
                AccountIds = new System.Collections.Generic.List<int> { 0, 3 },
                EntityTypeId = 90
            };
            var results = RockClient.FinancialRealm.Transactions.FindBy<TransactionDetail>(qo, "api/FinancialTransactionDetails/");
            results.Data.ShouldNotBe(null);
        }
    }
}
