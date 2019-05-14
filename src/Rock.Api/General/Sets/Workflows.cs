using Rock.Api.General.Model;
using Rock.Api.General.QueryObject;
using Rock.Api.Model;

namespace Rock.Api.General.Sets {
    public class Workflows : ApiSet<Workflow> {
        private const string LIST_URL = "api/workflows/";
        private const string GET_URL = "/api/workflows/{0}";
        private const string SEARCH_URL = "/api/workflows/";
        private const string CREATE_URL = "/api/workflows";
        private const string EDIT_URL = "/api/workflows/{0}";

        public Workflows(string baseUrl, string apiToken) : base(baseUrl, apiToken, ContentType.JSON) { }

        protected override string GetUrl { get { return GET_URL; } }

        protected override string SearchUrl { get { return SEARCH_URL; } }

        protected override string CreateUrl { get { return CREATE_URL; } }

        protected override string EditUrl { get { return EDIT_URL; } }

        protected override string ListUrl { get { return LIST_URL; } }
    }
}
