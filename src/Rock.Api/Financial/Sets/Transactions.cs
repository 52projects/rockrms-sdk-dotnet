using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rock.Api.Model;
using Rock.Api.Financial.Model;
using Rock.Api.Financial.QueryObject;

namespace Rock.Api.Financial.Sets {
    public class Transactions : ApiSet<Model.Transaction> {
        private const string LIST_URL = "api/financialtransactions/";
        private const string GET_URL = "/api/financialtransactions/{0}";
        private const string SEARCH_URL = "/api/financialtransactions/";
        private const string CREATE_URL = "/api/financialtransactions";
        private const string EDIT_URL = "/api/financialtransactions/{0}";

        public Transactions(string baseUrl, string apiToken) : base(baseUrl, apiToken, ContentType.JSON) { }

        protected override string GetUrl { get { return GET_URL; } }
        protected override string SearchUrl { get { return SEARCH_URL; } }
        protected override string CreateUrl { get { return CREATE_URL; } }
        protected override string EditUrl { get { return EDIT_URL; } }

        protected override string ListUrl { get { return LIST_URL; } }

        public override IRockResponse<Transaction> Get(string id) {
            var transactionResult = base.Get(id);

            if (!transactionResult.IsSuccessful) {
                return transactionResult;
            }

            var detailsResult = FindDetails(transactionResult.Data.Id.Value);
            if (detailsResult.IsSuccessful) {
                transactionResult.Data.TransactionDetails = detailsResult.Data.Items;
            }

            var paymentDetailResult = GetPaymentDetail(transactionResult.Data.FinancialPaymentDetailId.Value);
            if (paymentDetailResult.IsSuccessful) {
                transactionResult.Data.FinancialPaymentDetail = paymentDetailResult.Data;
            }

            return transactionResult;
        }

        public IRockResponse<TransactionDetail> GetDetail(string id) {
            return GetBySuffixUrl<TransactionDetail>("api/FinancialTransactionDetails/" + id);
        }

        public IRockResponse DeleteTransactionDetail(TransactionDetail detailItem) {
            return Delete("api/FinancialTransactionDetails/" + detailItem.Id);
        }

        public IRockResponse<RockCollection<TransactionDetail>> FindDetails(int transactionId) {
            return FindBy<TransactionDetail>(new TransactionDetailQO { TransactionId = transactionId, IncludeAttributes = true }, "api/financialtransactiondetails");
        }

        public IRockResponse<PaymentDetail> GetPaymentDetail(int paymentDetailId) {
            return GetBySuffixUrl<PaymentDetail>("api/financialpaymentdetails/" + paymentDetailId);
        }

        public IRockResponse<int> CreatePaymentDetails(PaymentDetail paymentDetail) {
            return Create(paymentDetail, "api/financialpaymentdetails/");
        }

        public IRockResponse DeletePaymentDetails(int id) {
            return Delete("api/financialpaymentdetails/" + id);
        }


        public IRockResponse<int> CreateTransactionDetail(TransactionDetail transactionDetail) {
            return Create(transactionDetail, "api/financialtransactiondetails/");
        }
    }
}