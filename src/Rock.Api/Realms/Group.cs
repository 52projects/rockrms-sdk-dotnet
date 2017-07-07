using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock.Api.Realms {
    public class Group {
        #region declarations
        private string _domainUrl;
        private string _apiToken;
        #endregion declarations

        #region Constructor
        public Group(string domainUrl, string apiToken) {
            _domainUrl = domainUrl;
            _apiToken = apiToken;
        }
        #endregion Constructor

        private Rock.Api.Groups.Sets.Groups _groupsSet;
        public Rock.Api.Groups.Sets.Groups Groups {
            get {
                if (_groupsSet == null) {
                    _groupsSet = new Groups.Sets.Groups(this._domainUrl, this._apiToken);
                }
                return _groupsSet;
            }
        }


        private Rock.Api.Groups.Sets.GroupMembers _groupMembersSet;
        public Rock.Api.Groups.Sets.GroupMembers GroupMembers {
            get {
                if (_groupMembersSet == null) {
                    _groupMembersSet = new Groups.Sets.GroupMembers(this._domainUrl, this._apiToken);
                }
                return _groupMembersSet;
            }
        }

        private Rock.Api.Groups.Sets.GroupLocations _groupLocationsSet;
        public Rock.Api.Groups.Sets.GroupLocations GroupLocations {
            get {
                if (_groupLocationsSet == null) {
                    _groupLocationsSet = new Groups.Sets.GroupLocations(this._domainUrl, this._apiToken);
                }
                return _groupLocationsSet;
            }
        }
    }
}
