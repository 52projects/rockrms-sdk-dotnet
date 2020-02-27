using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rock.Api.Attributes;

namespace Rock.Api.Groups.QueryObject {
    public class GroupMemberQO : BaseQO {
        [QOIgnore()]
        public int? GroupId { get; set; }

        /// <summary>
        /// After the search options have been created, a filter is created to send to Rock
        /// </summary>
        [QO("$filter")]
        public string Filter {
            get {
                var filterList = new List<string>();
                if (this.GroupId.HasValue) {
                    filterList.Add("GroupId eq " + this.GroupId.Value);
                }

                return string.Join(" and ", filterList);
            }
        }
    }
}