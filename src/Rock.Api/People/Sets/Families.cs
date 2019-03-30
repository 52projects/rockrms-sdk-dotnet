using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rock.Api.People.Model;
using Rock.Api.People.QueryObject;
using Rock.Api.Model;
using Rock.Api.Groups.Model;

namespace Rock.Api.People.Sets {
    public class Families : ApiSet<Family> {
        private const string GET_URL = "/api/groups/getfamily/{0}";
        private const string CREATE_URL = "/api/Groups";

        public Families(string baseUrl, string apiToken) : base(baseUrl, apiToken, ContentType.JSON) { }

        protected override string GetUrl { get { return GET_URL; } }

        protected override string CreateUrl => CREATE_URL;

        public IRockResponse<List<Family>> GetFamilies(int personID) {
            return base.ListBySuffixUrl<Family>("/api/groups/getfamilies/" + personID);
        }

        public override IRockResponse<int> Create(Family entity, out string requestXml, string url = "") {
            throw new NotImplementedException("Use the family service to create families");
        }

        public override IRockResponse<int> Create(Family entity, string url = "") {
            throw new NotImplementedException("Use the family service to create families");
        }

        public override IRockResponse<int> Create<S>(S entity, string url = "") {
            throw new NotImplementedException("Use the family service to create families");
        }
    }
}