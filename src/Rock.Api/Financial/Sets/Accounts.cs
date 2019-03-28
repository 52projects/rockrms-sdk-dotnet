using Rock.Api.People.QueryObject;
using Rock.Api.Model;

namespace Rock.Api.Financial.Sets {
    public class Accounts : ApiSet<Model.Account> {
        private const string LIST_URL = "api/financialaccounts/";
        private const string GET_URL = "/api/financialaccounts/{0}";
        private const string SEARCH_URL = "/api/financialaccounts/";
        private const string CREATE_URL = "/api/financialaccounts";
        private const string EDIT_URL = "/api/financialaccounts/{0}";

        public Accounts(string baseUrl, string apiToken) : base(baseUrl, apiToken, ContentType.JSON) { }

        protected override string GetUrl { get { return GET_URL; } }
        protected override string SearchUrl { get { return SEARCH_URL; } }
        protected override string CreateUrl { get { return CREATE_URL; } }
        protected override string EditUrl { get { return EDIT_URL; } }

        protected override string ListUrl { get { return LIST_URL; } }
    }
}
