using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rock.Api.General.Sets;

namespace Rock.Api.Realms {
    public class General {
        #region declarations
        private string _domainUrl;
        private string _apiToken;
        private Rock.Api.General.Sets.DefinedValues _definedValuesSet;
        #endregion declarations

        #region Constructor
        public General(string domainUrl, string apiToken) {
            _domainUrl = domainUrl;
            _apiToken = apiToken;
        }
        #endregion Constructor

        #region Sets

        public DefinedValues DefinedValues {
            get {
                if (_definedValuesSet == null) {
                    _definedValuesSet = new DefinedValues(this._domainUrl, this._apiToken);
                }
                return _definedValuesSet;
            }
        }

        #endregion Sets
    }
}
