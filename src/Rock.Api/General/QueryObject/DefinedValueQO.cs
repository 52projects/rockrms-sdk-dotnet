﻿using System.Reflection;
using Rock.Api.Attributes;
using System.Collections.Generic;
using Rock.Api.General.Enum;

namespace Rock.Api.General.QueryObject {
    public class DefinedValueQO : BaseQO {
        [QOIgnore()]
        public SystemDefinedType? DefinedTypeId { get; set; }

        [QO("loadAttributes")]
        public bool? IncludeAttributes { get; set; }

        /// <summary>
        /// After the search options have been created, a filter is created to send to Rock
        /// </summary>
        [QO("$filter")]
        public string Filter {
            get {
                var filterList = new List<string>();
                if (DefinedTypeId.HasValue) {
                    filterList.Add("DefinedTypeId eq " + (int)DefinedTypeId.Value);
                }

                return string.Join(" and ", filterList);
            }
        }
    }
}
