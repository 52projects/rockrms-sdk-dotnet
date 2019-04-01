using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock.Api.Financial.Model {
    public class PaymentDetail {
        public string AccountNumberMasked { get; set; }

        public int CurrencyTypeValueId { get; set; }

        public string NameOnCardEncrypted { get; set; }

        public string ExpirationYearEncrypted { get; set; }

        public int? BillingLocationId { get; set; }

        public string NameOnCard { get; set; }

        public int? ExpirationMonth { get; set; }

        public int? ExpirationYear { get; set; }
    }
}
