using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rock.Api.People.Model;
using Rock.Api.People.QueryObject;
using Rock.Api.Model;

namespace Rock.Api.People.Sets {
    public class Families : ApiSet<Model.Family> {
        private const string GET_URL = "/api/groups/getfamily/{0}";
        private const string CREATE_URL = "/api/Groups";

        public Families(string baseUrl, string apiToken) : base(baseUrl, apiToken, ContentType.JSON) { }

        protected override string GetUrl { get { return GET_URL; } }

        protected override string CreateUrl => CREATE_URL;
    }
}