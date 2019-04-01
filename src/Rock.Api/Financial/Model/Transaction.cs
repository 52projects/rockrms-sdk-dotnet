using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rock.Api.Model;

namespace Rock.Api.Financial.Model {
    public class Transaction : ApiModel {
        public Transaction() {
            TransactionDetails = new List<TransactionDetail>();
        }

        public int AuthorizedPersonAliasId { get; set; }

        public bool ShowAsAnonymous { get; set; }

        public int? BatchId { get; set; }

        public int? FinancialGatewayId { get; set; }

        public int? FinancialPaymentDetailId { get; set; }

        public DateTime TransactionDateTime { get; set; }

        public string TransactionCode { get; set; }

        public string Summary { get; set; }

        public int TransactionTypeValueId { get; set; }

        public int? SourceTypeValueId { get; set; }

        public string CheckMicrEncrypted { get; set; }

        public string CheckMicrHash { get; set; }

        public string MICRStatus { get; set; }

        public string CheckMicrParts { get; set; }

        public int? ScheduledTransactionId { get; set; }

        public bool? IsSettled { get; set; }

        public int? SettledGroupId { get; set; }

        public DateTime? SettledDate { get; set; }

        public bool? IsReconciled { get; set; }

        public string Status { get; set; }

        public string StatusMessage { get; set; }

        public DateTime SundayDate { get; set; }

        public List<TransactionDetail> TransactionDetails { get; set; }

        public PaymentDetail FinancialPaymentDetail { get; set; }
    }
}
