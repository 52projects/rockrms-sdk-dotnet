using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock.Api.Model {
    public class AttributeApiModel : ApiModel {
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
