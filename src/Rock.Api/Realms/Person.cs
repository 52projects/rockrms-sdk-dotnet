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
        private Rock.Api.People.Sets.People _peopleSet;
        private Rock.Api.People.Sets.PhoneNumbers _phoneNumbersSet;
        private Rock.Api.People.Sets.Locations _locationSet;
        private Rock.Api.People.Sets.ConnectionStatuses _connectionStatusSet;
        #endregion declarations

        #region Constructor
        public Person(string domainUrl, string apiToken) {
            _domainUrl = domainUrl;
            _apiToken = apiToken;
        }
        #endregion Constructor

        #region Sets
        
        public Rock.Api.People.Sets.People People {
            get {
                if (_peopleSet == null) {
                    _peopleSet = new People.Sets.People(this._domainUrl, this._apiToken);
                }
                return _peopleSet;
            }
        }

        public Rock.Api.People.Sets.PhoneNumbers PhoneNumbers {
            get {
                if (_phoneNumbersSet == null) {
                    _phoneNumbersSet = new People.Sets.PhoneNumbers(this._domainUrl, this._apiToken);
                }
                return _phoneNumbersSet;
            }
        }

        public Rock.Api.People.Sets.Locations Locations {
            get {
                if (_locationSet == null) {
                    _locationSet = new People.Sets.Locations(this._domainUrl, this._apiToken);
                }
                return _locationSet;
            }
        }

        public Rock.Api.People.Sets.ConnectionStatuses ConnectionStatuses {
            get {
                if (_connectionStatusSet == null) {
                    _connectionStatusSet = new People.Sets.ConnectionStatuses(_domainUrl, _apiToken);
                }

                return _connectionStatusSet;
            }
        }
        #endregion Sets
    }
}
