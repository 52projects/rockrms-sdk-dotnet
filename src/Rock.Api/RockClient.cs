using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rock.Api.People.Sets;

namespace Rock.Api {
    public class RockClient {
        #region declarations
        private string _domainUrl;
        private string _apiToken;

        public Rock.Api.Realms.Person PeopleRealm;
        public Rock.Api.Realms.Group GroupRealm;
        #endregion declarations

        /// <summary>
        /// Instantiate a new Rock Client for calling api methods
        /// </summary>
        /// <param name="domainUrl">The root domain of where rock is installed. ex: rock.rocksolidchurchdemo.com</param>
        /// <param name="apiToken">the API token that was created from Rock</param>
        public RockClient(string domainUrl, string apiToken) {
            this._domainUrl = domainUrl;
            this._apiToken = apiToken;

            this.PeopleRealm = new Realms.Person(domainUrl, apiToken);
            this.GroupRealm = new Realms.Group(domainUrl, apiToken);
        }
    }
}
