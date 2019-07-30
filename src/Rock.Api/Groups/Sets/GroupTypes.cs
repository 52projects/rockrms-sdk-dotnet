using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rock.Api.Groups.Model;
using Rock.Api.Model;
using Rock.Api.Groups.QueryObject;

namespace Rock.Api.Groups.Sets {
    public class GroupTypes : ApiSet<GroupType> {
        private const string LIST_URL = "api/grouptypes/";
        private const string GET_URL = "/api/grouptypes/{0}";
        private const string SEARCH_URL = "/api/grouptypes/";
        private const string CREATE_URL = "/api/grouptypes";
        private const string EDIT_URL = "/api/grouptypes/{0}";

        public GroupTypes(string baseUrl, string apiToken) : base(baseUrl, apiToken, ContentType.JSON) { }

        protected override string GetUrl { get { return GET_URL; } }
        protected override string SearchUrl { get { return SEARCH_URL; } }
        protected override string CreateUrl { get { return CREATE_URL; } }
        protected override string EditUrl { get { return EDIT_URL; } }

        protected override string ListUrl { get { return LIST_URL; } }

        public IRockResponse<RockCollection<GroupRole>> FindGroupRoles(int groupTypeID) {
            var qo = new GroupRoleQO { GroupTypeID = groupTypeID };
            return FindBy<GroupRole>(qo, "/api/grouptyperoles");
        }
    }
}
