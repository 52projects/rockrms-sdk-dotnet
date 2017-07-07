using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rock.Api.Groups.Model;
using Rock.Api.Groups.QueryObject;
using Rock.Api.Model;

namespace Rock.Api.Groups.Sets {
    public class GroupLocations : ApiSet<Model.GroupLocation> {
        private const string LIST_URL = "api/GroupLocations/";
        private const string GET_URL = "/api/GroupLocations/{0}";
        private const string SEARCH_URL = "/api/GroupLocations";
        private const string CREATE_URL = "/api/locations";
        private const string EDIT_URL = "/api/locations/{0}";

        public GroupLocations(string baseUrl, string apiToken) : base(baseUrl, apiToken, ContentType.JSON) { }

        protected override string GetUrl { get { return GET_URL; } }
        protected override string SearchUrl { get { return SEARCH_URL; } }
        protected override string CreateUrl { get { return CREATE_URL; } }
        protected override string EditUrl { get { return EDIT_URL; } }

        protected override string ListUrl { get { return LIST_URL; } }

        public RockCollection<GroupLocation> GetByGroupID(int groupID) {
            var qo = new GroupLocationQO { GroupId = groupID };
            return base.FindBy(qo);
        }
    }
}
