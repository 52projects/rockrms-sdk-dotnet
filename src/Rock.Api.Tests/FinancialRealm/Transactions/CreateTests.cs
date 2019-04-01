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
    public class CreateTests : Base {
        [Test]
        public void financial_transactions_create() {
            var transaction = new Transaction {
                IsReconciled = true,
                IsSettled = true,
                SettledDate = DateTime.UtcNow,
                TransactionDateTime = DateTime.UtcNow,
                SourceTypeValueId = 714
            };

            var results = this.RockClient.FinancialRealm.Transactions.Create(transaction);
            var transactionDetail = new TransactionDetail {
                TransactionId = results.Data,
                Amount = 125,
                AccountId = 5,
                Summary = "Details of transaction"
            };

            var transactionDetailResults = RockClient.FinancialRealm.Transactions.Create(transactionDetail);
            transactionDetailResults.Data.ShouldBeGreaterThan(0);
        }
    }
}
