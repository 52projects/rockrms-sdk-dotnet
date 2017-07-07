using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rock.Api.People.Model;
using Rock.Api.People.QueryObject;
using Rock.Api.Model;

namespace Rock.Api.People.Sets {
    public class Locations : ApiSet<Model.Location> {
        private const string LIST_URL = "api/Locations/";
        private const string GET_URL = "/api/Locations/{0}";
        private const string SEARCH_URL = "/api/locations/";
        private const string CREATE_URL = "/api/locations";
        private const string EDIT_URL = "/api/locations/{0}";

        public Locations(string baseUrl, string apiToken) : base(baseUrl, apiToken, ContentType.JSON) { }

        protected override string GetUrl { get { return GET_URL; } }
        protected override string SearchUrl { get { return SEARCH_URL; } }
        protected override string CreateUrl { get { return CREATE_URL; } }
        protected override string EditUrl { get { return EDIT_URL; } }

        protected override string ListUrl { get { return LIST_URL; } }

        public Location GetByPersonID(int personID) {
            return null;
        }

        //public override Person Get(string id) {
        //    var qo = new PersonQO { ID = int.Parse(id) };
        //    var response = base.FindBy(qo);
        //    if (response.Items.Count == 1) {
        //        return response.Items.First();
        //    }
        //    return null;
        //}

        //public RockCollection<Model.Person> FindByEmail(string email) {
        //    var qo = new PersonQO { Email = email };
        //    var response = base.FindBy(qo);
        //    return response;
        //}

        //private RockCollection<Model.Person> FindAll(PersonQO qo) {
        //    var response = base.FindBy(qo);
        //    return response;
        //}
    }
}