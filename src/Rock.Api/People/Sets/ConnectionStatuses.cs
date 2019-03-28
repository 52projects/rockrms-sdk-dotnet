using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rock.Api.People.Model;
using Rock.Api.General.QueryObject;
using Rock.Api.Model;
using Rock.Api.General.Enum;
using Rock.Api.General.Sets;

namespace Rock.Api.People.Sets {
    public class ConnectionStatuses : DefinedValues {
        public ConnectionStatuses(string baseUrl, string apiToken) : base(baseUrl, apiToken) { }

        public IRockResponse<RockCollection<ConnectionStatus>> FindAll() {
            var qo = new DefinedValueQO { DefinedTypeId = SystemDefinedType.ConnectionStatus };
            return FindBy<ConnectionStatus>(qo);
        }
    }
}