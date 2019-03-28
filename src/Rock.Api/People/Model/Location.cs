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
    public class Location : ApiModel {
        public string LocationTypeValue { get; set; }

        public int? LocationTypeValueId { get; set; }

        public int? ParentLocationId {get; set; }

        public bool IsActive { get; set; }

        public string Street1 { get; set; }

        public string Street2 { get; set; }

        public string City { get; set; }

        public string County { get; set; }

        public string State { get; set; }

        public string Country { get; set; }

        public string PostalCode { get; set; }

        public string Barcode { get; set; }

        public int? AssessorParcelId { get; set; }

        public int? SoftRoomThreshold { get; set; }

        public int? FirmRoomThreshold { get; set; }

        public bool IsNamedLocation { get; set; }

        public decimal? Latitude { get; set; }

        public decimal? Longitude { get; set; }
    }
}