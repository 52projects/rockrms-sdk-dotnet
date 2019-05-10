using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rock.Api.People.Model;
using Rock.Api.People.QueryObject;
using Rock.Api.Model;

namespace Rock.Api.People.Sets {
    public class BackgroundChecks : ApiSet<BackgroundCheck> {
        private const string LIST_URL = "api/backgroundchecks/";
        private const string GET_URL = "/api/backgroundchecks/{0}";
        private const string SEARCH_URL = "/api/backgroundchecks/";
        private const string CREATE_URL = "/api/backgroundchecks";
        private const string EDIT_URL = "/api/backgroundchecks/{0}";

        public BackgroundChecks(string baseUrl, string apiToken) : base(baseUrl, apiToken, ContentType.JSON) { }

        protected override string GetUrl { get { return GET_URL; } }
        protected override string SearchUrl { get { return SEARCH_URL; } }
        protected override string CreateUrl { get { return CREATE_URL; } }
        protected override string EditUrl { get { return EDIT_URL; } }

        protected override string ListUrl { get { return LIST_URL; } }
    }
}
