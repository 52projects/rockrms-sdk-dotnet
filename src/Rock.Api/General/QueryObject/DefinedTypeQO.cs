using System.Reflection;
using Rock.Api.Attributes;
using System.Collections.Generic;

namespace Rock.Api.General.QueryObject {
    public class DefinedTypeQO : BaseQO {
        public DefinedTypeQO() {
            ExpandEntities.Add("DefinedValues");
        }
    }
}
