using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rock.Api.Model;

namespace Rock.Api.General.Model {
    public class DefinedType : ApiModel {
        public bool IsSystem { get; set; }

        public int FieldTypeId { get; set; }

        public int Order { get; set; }

        public int CategoryId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string HelpText { get; set; }

        public bool IsActive { get; set; }

        public List<DefinedValue> DefinedValues {get; set; }
    }
}