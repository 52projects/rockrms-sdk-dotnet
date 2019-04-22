using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rock.Api.General.Model;
using Rock.Api.General.QueryObject;
using Rock.Api.Model;
using Rock.Api.General.Enum;

namespace Rock.Api.General.Sets {
    public class AttributeValues : ApiSet<AttributeValue> {
        private const string LIST_URL = "api/attributevalues/";
        private const string GET_URL = "/api/attributevalues/{0}";
        private const string SEARCH_URL = "/api/attributevalues/";
        private const string CREATE_URL = "/api/attributevalues";
        private const string EDIT_URL = "/api/attributevalues/{0}";

        public AttributeValues(string baseUrl, string apiToken) : base(baseUrl, apiToken, ContentType.JSON) { }

        protected override string GetUrl { get { return GET_URL; } }

        protected override string SearchUrl { get { return SEARCH_URL; } }

        protected override string CreateUrl { get { return CREATE_URL; } }

        protected override string EditUrl { get { return EDIT_URL; } }

        protected override string ListUrl { get { return LIST_URL; } }

        public IRockResponse<RockCollection<AttributeValue>> FindByEntityID(int entityId) {
            var qo = new AttributeValueQO { EntityId = entityId };
            return FindBy(qo);
        }
    }
}