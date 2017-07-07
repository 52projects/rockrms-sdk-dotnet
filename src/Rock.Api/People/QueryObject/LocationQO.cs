using System.Reflection;
using Rock.Api.Attributes;
using System.Collections.Generic;

namespace Rock.Api.People.QueryObject {
    public class LocationQO : BaseQO {
        [QOIgnore()]
        public int GroupLocationTypeValueID { get; set; }

        [QOIgnore()]
        public int PersonID { get; set; }
    }
}
