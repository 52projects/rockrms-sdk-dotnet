using Rock.Api.General.Model;
using Rock.Api.General.QueryObject;
using Rock.Api.Model;

namespace Rock.Api.General.Sets {
    public class Attributes : ApiSet<Attribute> {
        private const string LIST_URL = "api/attributes/";
        private const string GET_URL = "/api/attributes/{0}";
        private const string SEARCH_URL = "/api/attributes/";
        private const string CREATE_URL = "/api/attributes";
        private const string EDIT_URL = "/api/attributes/{0}";

        public Attributes(string baseUrl, string apiToken) : base(baseUrl, apiToken, ContentType.JSON) { }

        protected override string GetUrl { get { return GET_URL; } }

        protected override string SearchUrl { get { return SEARCH_URL; } }

        protected override string CreateUrl { get { return CREATE_URL; } }

        protected override string EditUrl { get { return EDIT_URL; } }

        protected override string ListUrl { get { return LIST_URL; } }

        public IRockResponse<RockCollection<Attribute>> FindByEntityTypeID(int entityType) {
            var qo = new AttributeQO { EntityTypeId = entityType };
            return FindBy(qo);
        }
    }
}
