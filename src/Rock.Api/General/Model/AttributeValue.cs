using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rock.Api.General.Enum;
using Rock.Api.Model;

namespace Rock.Api.General.Model {

    public class AttributeValue : ApiModel {
        public bool IsSystem { get; set; }

        public int AttributeId { get; set; }

        public int EntityId { get; set; }

        public string Value { get; set; }
    }
}