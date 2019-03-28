﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rock.Api.Financial.Sets;

namespace Rock.Api.Realms {
    public class Financial {
        #region declarations
        private string _domainUrl;
        private string _apiToken;
        private Accounts _accountsSet;
        private Pledges _pledgesSet;
        #endregion declarations

        #region Constructor
        public Financial(string domainUrl, string apiToken) {
            _domainUrl = domainUrl;
            _apiToken = apiToken;
        }
        #endregion Constructor
        
        public Accounts Accounts {
            get {
                if (_accountsSet == null) {
                    _accountsSet = new Accounts(this._domainUrl, this._apiToken);
                }
                return _accountsSet;
            }
        }

        public Pledges Pledges {
            get {
                if (_pledgesSet == null) {
                    _pledgesSet = new Pledges(this._domainUrl, this._apiToken);
                }
                return _pledgesSet;
            }
        }
    }
}
