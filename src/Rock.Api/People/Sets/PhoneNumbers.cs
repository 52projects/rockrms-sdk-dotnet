using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rock.Api.People.Model;
using Rock.Api.People.QueryObject;
using Rock.Api.Model;

namespace Rock.Api.People.Sets {
    public class PhoneNumbers : ApiSet<Model.PhoneNumber> {
        private const string LIST_URL = "api/phonenumbers/";
        private const string GET_URL = "/api/phonenumbers/{0}";
        private const string SEARCH_URL = "/api/phonenumbers/";
        private const string CREATE_URL = "/api/phonenumbers";
        private const string EDIT_URL = "/api/phonenumbers/{0}";

        public PhoneNumbers(string baseUrl, string apiToken) : base(baseUrl, apiToken, ContentType.JSON) { }

        protected override string GetUrl { get { return GET_URL; } }
        protected override string SearchUrl { get { return SEARCH_URL; } }
        protected override string CreateUrl { get { return CREATE_URL; } }
        protected override string EditUrl { get { return EDIT_URL; } }

        protected override string ListUrl { get { return LIST_URL; } }

        public RockCollection<Model.PhoneNumber> FindByNumber(string number) {
            var qo = new PhoneNumberQO { Number = number };
            var response = base.FindBy(qo);
            return response;
        }
    }
}
