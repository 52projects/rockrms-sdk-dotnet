using System.Reflection;
using Rock.Api.Attributes;
using System.Collections.Generic;

namespace Rock.Api.People.QueryObject {
    public class PhoneNumberQO : BaseQO {
        [QOIgnore()]
        public string Number { get; set; }

        /// <summary>
        /// After the search options have been created, a filter is created to send to Rock
        /// </summary>
        [QO("$filter")]
        public string Filter {
            get {
                var filterList = new List<string>();
                if (!string.IsNullOrEmpty(this.Number)) {
                    filterList.Add("Number eq '" + this.Number + "'");
                }
               
                return string.Join(" and ", filterList);
            }
        }
    }
}
