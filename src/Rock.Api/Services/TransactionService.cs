using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rock.Api.Financial.Model;
using Rock.Api.Exceptions;
using Rock.Api.Model;

namespace Rock.Api.Services {
    public interface ITransactionService {
        IRockResponse<int> CreateTransaction(Transaction transaction);
    }

    public class TransactionService : BaseService, ITransactionService {
        public TransactionService(string domainUrl, string apiToken) : base(domainUrl, apiToken) {

        }

        public IRockResponse<int> CreateTransaction(Transaction transaction) {
            if (transaction.FinancialPaymentDetail == null) {
                throw new NotImplementedException("The Financial Payment Detail cannot be null");
            }

            if (transaction.TransactionDetails == null || transaction.TransactionDetails.Count == 0) {
                throw new NotImplementedException("At least one transaction detail item is required");
            }

            // First we need to create the payment detail
            var paymentDetailResult = RockClient.FinancialRealm.Transactions.CreatePaymentDetails(transaction.FinancialPaymentDetail);
            if (!paymentDetailResult.IsSuccessful) {
                return paymentDetailResult;
            }

            transaction.FinancialPaymentDetailId = paymentDetailResult.Data;
            transaction.FinancialPaymentDetail = null;

            var transactionResult = RockClient.FinancialRealm.Transactions.Create(transaction);


            if (!transactionResult.IsSuccessful) {
                return transactionResult;
            }

            foreach (var transactionDetail in transaction.TransactionDetails) {
                transactionDetail.TransactionId = transactionResult.Data;
                var result = RockClient.FinancialRealm.Transactions.CreateTransactionDetail(transactionDetail);

                if (!result.IsSuccessful) {
                    return result;
                }
            }
            return transactionResult;
        }
    }
}
