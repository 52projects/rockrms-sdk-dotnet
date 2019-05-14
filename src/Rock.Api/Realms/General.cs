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
        private DefinedValues _definedValuesSet;
        private AttributeValues _attributeValuesSet;
        private Rock.Api.General.Sets.Attributes _attributesSet;
        private Rock.Api.General.Sets.Workflows _workflowSet;
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

        public AttributeValues AttributeValues {
            get {
                if (_attributeValuesSet == null) {
                    _attributeValuesSet = new AttributeValues(_domainUrl, _apiToken);
                }
                return _attributeValuesSet;
            }
        }

        public Rock.Api.General.Sets.Attributes Attributes {
            get {
                if (_attributesSet == null) {
                    _attributesSet = new Api.General.Sets.Attributes(_domainUrl, _apiToken);
                }

                return _attributesSet;
            }
        }

        public Rock.Api.General.Sets.Workflows Workflows {
            get {
                if (_workflowSet == null) {
                    _workflowSet = new Api.General.Sets.Workflows(_domainUrl, _apiToken);
                }

                return _workflowSet;
            }
        }

        #endregion Sets
    }
}
