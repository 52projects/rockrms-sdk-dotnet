using System.Reflection;
using Rock.Api.Attributes;
using System.Collections.Generic;
using System;
using System.Text;

namespace Rock.Api.Financial.QueryObject {
    public class TransactionDetailQO : BaseQO {
        public TransactionDetailQO() {
            AccountIds = new List<int>();
        }

        /// <summary>
        /// The Transaction Id for which to retrieve details
        /// </summary>
        [QOIgnore()]
        public int? TransactionId { get; set; }

        [QOIgnore()]
        public int? AccountId { get; set; }

        [QOIgnore()]
        public List<int> AccountIds { get; set; }

        [QOIgnore()]
        public int? EntityTypeId { get; set; }

        [QOIgnore()]
        public int? EntityId { get; set; }

        [QOIgnore()]
        public DateTime? ModifiedDateTime { get; set; }

        [QO("loadAttributes")]
        public bool? IncludeAttributes { get; set; }

        /// <summary>
        /// After the search options have been created, a filter is created to send to Rock
        /// </summary>
        [QO("$filter")]
        public string Filter {
            get {
                var filterList = new List<string>();
                if (this.TransactionId.HasValue) {
                    filterList.Add("TransactionId eq " + TransactionId.Value);
                }
                if (ModifiedDateTime.HasValue) {
                    filterList.Add("ModifiedDateTime gt datetime'" + ModifiedDateTime.Value.ToString("yyyy-MM-ddThh:mm:ss") + "'");
                }
                if (EntityTypeId.HasValue) {
                    filterList.Add("EntityTypeId eq " + EntityTypeId.Value);
                }
                if (EntityId.HasValue) {
                    filterList.Add("EntityId eq " + EntityId.Value);
                }
                if (AccountId.HasValue) {
                    filterList.Add("AccountId eq " + AccountId.Value);
                }
                if (AccountIds.Count > 0) {
                    var accountSB = new StringBuilder();
                    var accountList = new List<string>();
                    accountSB.Append("(");
                    AccountIds.ForEach(x => accountList.Add("AccountId eq " + x));
                    accountSB.AppendFormat(string.Join(" or ", accountList));
                    accountSB.Append(")");

                    filterList.Add(accountSB.ToString());
                    
                }

                return string.Join(" and ", filterList);
            }
        }
    }
}
