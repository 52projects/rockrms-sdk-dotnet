using Rock.Api.Attributes;
using System.Collections.Generic;

namespace Rock.Api.Groups.QueryObject {
    public class GroupRoleQO : BaseQO {
        [QOIgnore()]
        public int? GroupTypeID { get; set; }

        /// <summary>
        /// After the search options have been created, a filter is created to send to Rock
        /// </summary>
        [QO("$filter")]
        public string Filter {
            get {
                var filterList = new List<string>();
                if (this.GroupTypeID.HasValue) {
                    filterList.Add("GroupTypeId eq " + this.GroupTypeID.Value);
                }

                return string.Join(" and ", filterList);
            }
        }
    }
}
