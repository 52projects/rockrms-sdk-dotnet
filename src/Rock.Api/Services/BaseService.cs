using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock.Api.Services {
    public class BaseService {
        public BaseService(string domainUrl, string apiToken) {
            RockClient = new RockClient(domainUrl, apiToken);
        }

        internal RockClient RockClient { get; }
    }
}
