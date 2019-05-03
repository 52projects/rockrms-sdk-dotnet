using System.Reflection;
using Rock.Api.Attributes;
using System.Collections.Generic;
using Rock.Api.General.Enum;

namespace Rock.Api.General.QueryObject {
    public class AttributeValueQO : BaseQO {
        [QOIgnore()]
        public int? EntityId { get; set; }

        [QOIgnore()]
        public int? AttributeId { get; set; }

        /// <summary>
        /// After the search options have been created, a filter is created to send to Rock
        /// </summary>
        [QO("$filter")]
        public string Filter {
            get {
                var filterList = new List<string>();
                if (EntityId.HasValue) {
                    filterList.Add("EntityId eq " + EntityId.Value);
                }

                if (AttributeId.HasValue) {
                    filterList.Add("AttributeId eq " + AttributeId.Value);
                }

                return string.Join(" and ", filterList);
            }
        }
    }
}