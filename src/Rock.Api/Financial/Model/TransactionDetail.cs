using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rock.Api.Model;

namespace Rock.Api.Financial.Model {
    public class TransactionDetail : ApiModel {
        public int TransactionId { get; set; }

        public int AccountId { get; set; }

        public bool IsNonCash { get; set; }

        public decimal Amount { get; set; }

        public string Summary { get; set; }

        public int? EntityTypeId { get; set; }

        public int? EntityId { get; set; }

        public int? ForeignId { get; set; }
    }
}