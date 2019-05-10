using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rock.Api.Model;

namespace Rock.Api.General.Model {
    public class DefinedValue : AttributeApiModel {
        public bool IsSystem { get; set; }

        public int DefinedTypeId { get; set; }

        public int Order { get; set; }

        public string Value { get; set; }

        public string Description { get; set; }

        public bool IsActive { get; set; }
    }
}
