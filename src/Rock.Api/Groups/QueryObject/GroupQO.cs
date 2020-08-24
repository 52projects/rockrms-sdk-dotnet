using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rock.Api.Attributes;

namespace Rock.Api.Groups.QueryObject {
    public class GroupQO : BaseQO {
        [QOIgnore()]
        public int? GroupId { get; set; }

        [QOIgnore()]
        public int? ParentGroupId { get; set; }

        [QOIgnore()]
        public int? GroupTypeId { get; set; }

        [QOIgnore()]
        public string Name { get; set; }

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

                if (this.ParentGroupId.HasValue) {
                    filterList.Add("ParentGroupId eq " + this.ParentGroupId.Value);
                }

                if (this.GroupTypeId.HasValue) {
                    filterList.Add("GroupTypeId eq " + this.GroupTypeId.Value);
                }

                if (!string.IsNullOrEmpty(Name)) {
                    filterList.Add("Name eq '" + this.Name + "'");
                }

                return string.Join(" and ", filterList);
            }
        }
    }
}