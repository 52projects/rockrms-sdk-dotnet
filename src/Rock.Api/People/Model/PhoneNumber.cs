using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rock.Api.Model;
using System.Xml;
using System.Xml.Serialization;
using Rock.Api.People.Enum;
using Newtonsoft.Json;

namespace Rock.Api.People.Model {
    public class PhoneNumber : ApiModel {
        public bool IsSystem { get; set; }
        public int PersonId { get; set; }
        public string CountryCode { get; set; }
        public string Number { get; set; }
        public string Extension { get; set; }
        public int? NumberTypeValueId { get; set; }
        public bool IsMessagingEnabled { get; set; }
        public bool IsUnlisted { get; set; }
        public string Description { get; set; }
    }
}
