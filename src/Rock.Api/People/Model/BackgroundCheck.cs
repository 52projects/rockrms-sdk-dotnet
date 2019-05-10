using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rock.Api.Model;

namespace Rock.Api.People.Model {
    public class BackgroundCheck : AttributeApiModel {
        public int PersonAliasId { get; set; }

        public int WorkflowId { get; set; }

        public DateTime RequestDate { get; set; }

        public object ResponseDate { get; set; }

        public object RecordFound { get; set; }

        public string ResponseData { get; set; }

        public object ResponseId { get; set; }

        public object RequestId { get; set; }

        public object ResponseDocumentId { get; set; }

        public object ProcessorEntityTypeId { get; set; }

        public object Status { get; set; }

        public object PackageName { get; set; }

        public object ProcessorEntityType { get; set; }

        public DateTime CreatedDateTime { get; set; }

        public DateTime ModifiedDateTime { get; set; }

        public int CreatedByPersonAliasId { get; set; }

        public int ModifiedByPersonAliasId { get; set; }

        public bool ModifiedAuditValuesAlreadyUpdated { get; set; }

        public string Guid { get; set; }

        public int ForeignId { get; set; }

        public object ForeignGuid { get; set; }

        public object ForeignKey { get; set; }
    }
}
