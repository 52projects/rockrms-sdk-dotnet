using System.Reflection;
using Rock.Api.Attributes;
using System.Collections.Generic;

namespace Rock.Api.People.QueryObject {
    public class UserLoginQO : BaseQO {
        public UserLoginQO() {

        }

        [QOIgnore()]
        public string UserName { get; set; }
        
        /// <summary>
        /// After the search options have been created, a filter is created to send to Rock
        /// </summary>
        [QO("$filter")]
        public string Filter {
            get {
                var filterList = new List<string>();
                if (!string.IsNullOrEmpty(UserName)) {
                    filterList.Add("UserName eq '" + UserName + "'");
                }

                return string.Join(" and ", filterList);
            }
        }
    }
}
