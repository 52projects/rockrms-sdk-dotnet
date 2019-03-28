using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock.Api.Financial.Sets {
    public class Pledges : ApiSet<Model.Pledge> {
        private const string LIST_URL = "api/financialpledges/";
        private const string GET_URL = "/api/financialpledges/{0}";
        private const string SEARCH_URL = "/api/financialpledges/";
        private const string CREATE_URL = "/api/financialpledges";
        private const string EDIT_URL = "/api/financialpledges/{0}";

        public Pledges(string baseUrl, string apiToken) : base(baseUrl, apiToken, ContentType.JSON) { }

        protected override string GetUrl { get { return GET_URL; } }
        protected override string SearchUrl { get { return SEARCH_URL; } }
        protected override string CreateUrl { get { return CREATE_URL; } }
        protected override string EditUrl { get { return EDIT_URL; } }

        protected override string ListUrl { get { return LIST_URL; } }
    }
}