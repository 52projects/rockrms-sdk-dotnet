﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rock.Api.People.Model;
using Rock.Api.People.QueryObject;
using Rock.Api.Model;

namespace Rock.Api.People.Sets {

    public class People : ApiSet<Model.Person> {
        private readonly string _baseUrl;

        private const string LIST_URL = "api/people/";
        private const string GET_URL = "/api/people/{0}";
        private const string SEARCH_URL = "/api/people/";
        private const string CREATE_URL = "/api/people";
        private const string EDIT_URL = "/api/people/{0}";
        private const string IMAGE_URL = "/api/people/{0}/images";
        private const string IMAGE_UPDATE_URL = "/v1/people/{0}/images/{1}";

        public People(string baseUrl, string apiToken) : base(baseUrl, apiToken, ContentType.JSON) {
            _baseUrl = baseUrl;
        }

        protected override string GetUrl { get { return GET_URL; } }

        protected override string SearchUrl { get { return SEARCH_URL; } }

        protected override string CreateUrl { get { return CREATE_URL; } }

        protected override string EditUrl { get { return EDIT_URL; } }

        protected override string ListUrl { get { return LIST_URL; } }

        public byte[] GetImage(string id, string size = "M") {
            var url = string.Format(IMAGE_URL, id, size);
            return this.GetByteArray(url);
        }

        public void CreateImage(string id, byte[] image, string filename, string fileType) {
            var request = this.CreateRestRequest(RestSharp.Method.POST, string.Format(IMAGE_URL, id), "image/jpeg");
            request.AddParameter("image", image, RestSharp.ParameterType.RequestBody);
            var response = this.ExecuteGenericRequest(request);
        }

        public void UpdateImage(string id, byte[] image, string filename, string fileType, string imageID) {
            var request = this.CreateRestRequest(RestSharp.Method.PUT, string.Format(IMAGE_UPDATE_URL, id, imageID), "image/jpeg");
            request.AddParameter("image", image, RestSharp.ParameterType.RequestBody);
            var response = this.ExecuteGenericRequest(request);
        }

        public IRockResponse<RockCollection<Person>> GetByID(string id) {
            var qo = new PersonQO { ID = int.Parse(id) };
            return base.FindBy(qo);
        }

        public IRockResponse<Person> GetByAliasID(string aliasID) {
            AddParameter("loadAttributes", "true");
            return GetBySuffixUrl<Person>("api/People/GetByPersonAliasId/" + aliasID);
        }

        public IRockResponse<RockCollection<Person>> FindByEmail(string email) {
            var qo = new PersonQO { Email = email };
            var response = base.FindBy(qo);
            return response;
        }

        public IRockResponse<RockCollection<Person>> FindAll(PersonQO qo) {
            var response = base.FindBy(qo);
            return response;
        }

        public IRockResponse<Family> GetFamily(int familyID) {
            return base.GetBySuffixUrl<Family>(string.Format("/api/groups/getfamily/{0}", familyID));
        }

        public IRockResponse<RockCollection<Person>> Login(string username, string password) {
            var client = new RestSharp.RestClient(_baseUrl);
            client.CookieContainer = new System.Net.CookieContainer();
            var request = CreateRestRequest(RestSharp.Method.POST, "api/auth/login");
            request.AddBody(new {
                UserName = username,
                Password = password
            });
            var response = client.ExecuteAsPost(request, "POST");

            if (response.StatusCode == System.Net.HttpStatusCode.Unauthorized) {
                return null;
            }
            var userLogins = FindBy<UserLogin>(new UserLoginQO { UserName = username }, "api/UserLogins");

            if (userLogins.IsSuccessful) {
                return GetByID(userLogins.Data.Items[0].PersonId.ToString());
            }

            return null;
        }
    }
}
