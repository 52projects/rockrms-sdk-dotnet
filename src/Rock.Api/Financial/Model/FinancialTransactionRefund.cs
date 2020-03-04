using Rock.Api.Model;
using System;

namespace Rock.Api.Financial.Model {
    public class FinancialTransactionRefund : ApiModel {
        public int OriginalTransactionId { get; set; }

        public Transaction FinancialTransaction { get; set; }

        public string RefundReasonSummary { get; set; }

        public int? RefundReasonValueId { get; set; }
    }
}