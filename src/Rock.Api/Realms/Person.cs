using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock.Api.Realms {
    public class Person {
        #region declarations
        private string _domainUrl;
        private string _apiToken;
        #endregion declarations

        #region Constructor
        public Person(string domainUrl, string apiToken) {
            _domainUrl = domainUrl;
            _apiToken = apiToken;
        }
        #endregion Constructor

        #region Sets
        private Rock.Api.People.Sets.People _peopleSet;
        public Rock.Api.People.Sets.People People {
            get {
                if (_peopleSet == null) {
                    _peopleSet = new People.Sets.People(this._domainUrl, this._apiToken);
                }
                return _peopleSet;
            }
        }
        #endregion Sets
    }
}
