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
    public class DefinedValues : ApiSet<DefinedValue> {
        private const string LIST_URL = "api/definedvalues/";
        private const string GET_URL = "/api/definedvalues/{0}";
        private const string SEARCH_URL = "/api/definedvalues/";
        private const string CREATE_URL = "/api/definedvalues";
        private const string EDIT_URL = "/api/definedvalues/{0}";

        public DefinedValues(string baseUrl, string apiToken) : base(baseUrl, apiToken, ContentType.JSON) { }

        protected override string GetUrl { get { return GET_URL; } }

        protected override string SearchUrl { get { return SEARCH_URL; } }

        protected override string CreateUrl { get { return CREATE_URL; } }

        protected override string EditUrl { get { return EDIT_URL; } }

        protected override string ListUrl { get { return LIST_URL; } }

        public IRockResponse<RockCollection<DefinedValue>> FindByType(SystemDefinedType definedType, bool loadAttributes = false) {
            var qo = new DefinedValueQO { DefinedTypeId = definedType, IncludeAttributes = loadAttributes};
            return FindBy(qo);
        }
    }
}