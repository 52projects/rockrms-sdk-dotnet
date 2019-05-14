using System.Reflection;
using Rock.Api.Attributes;
using System.Collections.Generic;

namespace Rock.Api.People.QueryObject {
    public class BackgroundCheckQO : BaseQO {
        public BackgroundCheckQO() {

        }

        [QOIgnore()]
        public int? PersonAliasId { get; set; }

        /// <summary>
        /// After the search options have been created, a filter is created to send to Rock
        /// </summary>
        [QO("$filter")]
        public string Filter {
            get {
                var filterList = new List<string>();
                if (this.PersonAliasId.HasValue) {
                    filterList.Add("PersonAliasId eq " + this.PersonAliasId.Value);
                }

                return string.Join(" and ", filterList);
            }
        }
    }
}
