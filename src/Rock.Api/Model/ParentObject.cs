using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Rock.Api.Model {
    [Serializable]
    public class ParentObject : ApiModel {
        public static ParentObject Default {
            get { return new ParentObject(); }
        }
    }

    [Serializable]
    public class ParentNamedObject : ApiModel {
        private string _name = string.Empty;
        [XmlElement("name")]
        [JsonProperty("name")]
        public string Name {
            get { return _name; }
            set { _name = value; }
        }

        public static ParentNamedObject Default {
            get { return new ParentNamedObject(); }
        }
    }
}