using System.Reflection;
using Rock.Api.Attributes;
using System.Collections.Generic;
using Rock.Api.General.Enum;

namespace Rock.Api.General.QueryObject {
    public class AttributeQO : BaseQO {
        [QOIgnore()]
        public EntityType? EntityTypeId { get; set; }

        /// <summary>
        /// After the search options have been created, a filter is created to send to Rock
        /// </summary>
        [QO("$filter")]
        public string Filter {
            get {
                var filterList = new List<string>();
                if (EntityTypeId.HasValue) {
                    filterList.Add("EntityTypeId eq " + (int)EntityTypeId.Value);
                }

                return string.Join(" and ", filterList);
            }
        }
    }
}
