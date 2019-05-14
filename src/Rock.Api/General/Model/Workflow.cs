using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rock.Api.Model;

namespace Rock.Api.General.Model {
    public class Workflow : AttributeApiModel {

        public class Rootobject {
            public int WorkflowTypeId { get; set; }

            public int WorkflowIdNumber { get; set; }

            public string WorkflowId { get; set; }

            public string Name { get; set; }

            public string Description { get; set; }

            public string Status { get; set; }

            public bool IsProcessing { get; set; }

            public DateTime ActivatedDateTime { get; set; }

            public DateTime LastProcessedDateTime { get; set; }

            public DateTime CompletedDateTime { get; set; }

            public int InitiatorPersonAliasId { get; set; }

            public object InitiatorPersonAlias { get; set; }

            public bool IsActive { get; set; }

            public object[] Activities { get; set; }

            public bool IsPersisted { get; set; }

            public DateTime CreatedDateTime { get; set; }

            public DateTime ModifiedDateTime { get; set; }

            public int CreatedByPersonAliasId { get; set; }

            public object ModifiedByPersonAliasId { get; set; }

            public bool ModifiedAuditValuesAlreadyUpdated { get; set; }

            public int Id { get; set; }

            public string Guid { get; set; }

            public object ForeignId { get; set; }

            public object ForeignGuid { get; set; }

            public object ForeignKey { get; set; }
        }

    }
}
