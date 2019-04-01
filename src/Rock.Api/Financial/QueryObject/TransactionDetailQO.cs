using System.Reflection;
using Rock.Api.Attributes;
using System.Collections.Generic;

namespace Rock.Api.Financial.QueryObject {
    public class TransactionDetailQO : BaseQO {
        /// <summary>
        /// The Transaction Id for which to retrieve details
        /// </summary>
        [QOIgnore()]
        public int? TransactionId { get; set; }

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

                return string.Join(" and ", filterList);
            }
        }
    }
}
