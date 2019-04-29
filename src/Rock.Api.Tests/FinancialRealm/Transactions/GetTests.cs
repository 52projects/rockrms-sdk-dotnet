using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Shouldly;
using Rock.Api.Financial.Model;

namespace Rock.Api.Tests.FinancialRealm.Transactions {
    [TestFixture]
    public class GetTests : Base {
        [Test]
        public void financial_transactions_get_including_details() {
            var results = this.RockClient.FinancialRealm.Transactions.List();

            var transactionResults = RockClient.FinancialRealm.Transactions.Get(results.Data[0].Id.ToString());
            var transactionDetails = RockClient.FinancialRealm.Transactions.FindDetails(transactionResults.Data.Id.Value);

            transactionResults.Data.TransactionDetails.Count.ShouldBeGreaterThan(0);
        }
    }
}
