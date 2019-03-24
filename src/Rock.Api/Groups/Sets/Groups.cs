using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rock.Api.Groups.Model;
using Rock.Api.Model;

namespace Rock.Api.Groups.Sets {
    public class Groups : ApiSet<Model.Group> {
        private const string LIST_URL = "api/Locations/";
        private const string GET_URL = "/api/GroupLocations/{0}";
        private const string SEARCH_URL = "/api/locations/";
        private const string CREATE_URL = "/api/locations";
        private const string EDIT_URL = "/api/locations/{0}";

        public Groups(string baseUrl, string apiToken) : base(baseUrl, apiToken, ContentType.JSON) { }

        protected override string GetUrl { get { return GET_URL; } }
        protected override string SearchUrl { get { return SEARCH_URL; } }
        protected override string CreateUrl { get { return CREATE_URL; } }
        protected override string EditUrl { get { return EDIT_URL; } }

        protected override string ListUrl { get { return LIST_URL; } }

        public Group GetByFamilyID(int familyID) {
            return null;
        }

        public IRockResponse<List<Group>> GetFamilies(int personID) {
            return base.ListBySuffixUrl<Group>("/api/Groups/GetFamilies/" + personID);
        }
    }
}
