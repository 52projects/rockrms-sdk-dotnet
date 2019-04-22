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
using Rock.Api.General.Model;

namespace Rock.Api.Groups.Model {
    public class Group : ApiModel {
        public Group() {
            AttributeValues = new List<AttributeValue>();
        }

        public bool IsSystem { get; set; }
        public int? ParentGroupId { get; set; }

        public int GroupTypeId { get; set; }

        public int? CampusId { get; set; }

        public int? ScheduleId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public bool IsSecurityRole { get; set; }

        public bool IsActive { get; set; }

        public int Order { get; set; }

        public bool? AllowGuests { get; set; }

        public bool IsPublic { get; set; }

        public int? GroupCapacity { get; set; }

        public int? RequiredSignatureDocumentTemplateId { get; set; }

        [JsonIgnore]
        public List<AttributeValue> AttributeValues { get; set; }
    }
}
