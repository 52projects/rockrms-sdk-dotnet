using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rock.Api.General.Enum;

namespace Rock.Api.General.Model {

    public class AttributeValue {
        public bool IsSystem { get; set; }
        public RockAttribute AttributeId { get; set; }
        public int EntityId { get; set; }
        public string Value { get; set; }
        public object[] AttributeValuesHistorical { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime ModifiedDateTime { get; set; }
        public int CreatedByPersonAliasId { get; set; }
        public int ModifiedByPersonAliasId { get; set; }
        public bool ModifiedAuditValuesAlreadyUpdated { get; set; }
        public int Id { get; set; }
        public string Guid { get; set; }
    }
}