using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rock.Api.Model;

namespace Rock.Api.General.Model {
    public class DefinedValue : ApiModel {
        public bool IsSystem { get; set; }

        public int DefinedTypeId { get; set; }

        public int Order { get; set; }

        public string Value { get; set; }

        public string Description { get; set; }

        public bool IsActive { get; set; }

        public dynamic Attributes { get; set; }

        public dynamic AttributeValues { get; set; }

        public string GetAttributeValue(string attributeKey) {
            if (AttributeValues == null) {
                return string.Empty;
            }

            var attributeValues = ((IDictionary<String, Object>)AttributeValues);

            if (!attributeValues.ContainsKey(attributeKey)) {
                return string.Empty;
            }

            var attributeValue = attributeValues[attributeKey];

            if (attributeValue == null) {
                return string.Empty;
            }

            return ((IDictionary<String, Object>)attributeValue)["Value"].ToString();
        }
    }
}
