using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit.Framework.Api;
using Shouldly;
using Rock.Api.Financial.Model;

namespace Rock.Api.Tests.FinancialRealm.Transactions {
    [TestFixture]
    public class CreateTests : Base {
        [Test]
        public void financial_transactions_create_no_payment_detail() {
            var transaction = new Transaction {
                IsReconciled = true,
                IsSettled = true,
                SettledDate = DateTime.UtcNow,
                TransactionDateTime = DateTime.UtcNow,
                SourceTypeValueId = 714
            };
            
            var ex = Assert.Throws<NotImplementedException>(() => TransactionService.CreateTransaction(transaction));
            ex.Message.ShouldContain("The Financial Payment Detail cannot be null");
        }

        [Test]
        public void financial_transactions_create_no_transaction_details() {
            var transaction = new Transaction {
                IsReconciled = true,
                IsSettled = true,
                SettledDate = DateTime.UtcNow,
                TransactionDateTime = DateTime.UtcNow,
                SourceTypeValueId = 714
            };

            transaction.FinancialPaymentDetail = new PaymentDetail();

            var ex = Assert.Throws<NotImplementedException>(() => TransactionService.CreateTransaction(transaction));
            ex.Message.ShouldContain("At least one transaction detail item is required");
        }

        [Test]
        public void financial_transactions_create_success() {
            var results = RockClient.PeopleRealm.People.FindByEmail("ted@rocksolidchurchdemo.com");
            var transaction = new Transaction {
                IsReconciled = true,
                IsSettled = true,
                SettledDate = DateTime.UtcNow,
                TransactionDateTime = DateTime.UtcNow,
                TransactionTypeValueId = 53,
                AuthorizedPersonAliasId = 16,
            };

            transaction.TransactionDetails.Add(new TransactionDetail {
                AccountId = 3,
                Amount = 125,
            });

            transaction.FinancialPaymentDetail = new PaymentDetail();

            var result = TransactionService.CreateTransaction(transaction);
            result.Data.ShouldBeGreaterThan(0);
        }
    }
}
