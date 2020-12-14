using System.Reflection;
using Rock.Api.Attributes;
using System.Collections.Generic;
using System;
using System.Text;

namespace Rock.Api.Financial.QueryObject {
    public class TransactionQO : BaseQO {
        [QO("TransactionCode")]
        public string TransactionCode { get; set; }

        /// <summary>
        /// After the search options have been created, a filter is created to send to Rock
        /// </summary>
        [QO("$filter")]
        public string Filter {
            get {
                var filterList = new List<string>();
                if (!string.IsNullOrEmpty(this.TransactionCode)) {
                    filterList.Add("TransactionCode eq '" + TransactionCode + "'");
                }

                return string.Join(" and ", filterList);
            }
        }
    }
}
