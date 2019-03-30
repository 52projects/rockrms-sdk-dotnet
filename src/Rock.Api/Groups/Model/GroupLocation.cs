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


namespace Rock.Api.Groups.Model {
    public class GroupLocation : ApiModel {
        public int GroupId { get; set; }

        public int LocationId { get; set; }

        public int? GroupLocationTypeValueId { get; set; }

        public bool IsMailingLocation { get; set; }

        public bool IsMappedLocation { get; set; }
    }
}
