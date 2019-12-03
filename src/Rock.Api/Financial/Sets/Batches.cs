using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock.Api.Financial.Sets {
    public class Batches : ApiSet<Model.Batch> {
        private const string LIST_URL = "api/financialbatches/";
        private const string GET_URL = "/api/financialbatches/{0}";
        private const string SEARCH_URL = "/api/financialbatches/";
        private const string CREATE_URL = "/api/financialbatches";
        private const string EDIT_URL = "/api/financialbatches/{0}";

        public Batches(string baseUrl, string apiToken) : base(baseUrl, apiToken, ContentType.JSON) { }

        protected override string GetUrl { get { return GET_URL; } }
        protected override string SearchUrl { get { return SEARCH_URL; } }
        protected override string CreateUrl { get { return CREATE_URL; } }
        protected override string EditUrl { get { return EDIT_URL; } }

        protected override string ListUrl { get { return LIST_URL; } }
    }
}