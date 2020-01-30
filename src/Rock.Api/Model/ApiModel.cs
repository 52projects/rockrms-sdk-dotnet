using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Rock.Api.Model {
    [Serializable]
    public class ApiModel {
        private IDictionary<string, object> _changes;

        public ApiModel() {
            _changes = new Dictionary<string, object>();
        }

        [JsonProperty(PropertyName = "Id", NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; }

        internal bool IsDirty {
            get {
                return _changes.Keys.Count() > 0;
            }
        }

        public string ToPatchJson() {
            return Newtonsoft.Json.JsonConvert.SerializeObject(_changes);
        }

        internal void TrackProperty(string propertyName, object value) {
            if (_changes.ContainsKey(propertyName)) {
                _changes[propertyName] = value;
            }
            else {
                _changes.Add(propertyName, value);
            }
        }
    }
}
