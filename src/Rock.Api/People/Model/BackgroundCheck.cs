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

        public DateTime? ResponseDate { get; set; }

        public bool RecordFound { get; set; }

        public string ResponseData { get; set; }

        public string ResponseId { get; set; }

        public string RequestId { get; set; }

        public int? ResponseDocumentId { get; set; }

        public int? ProcessorEntityTypeId { get; set; }

        public string Status { get; set; }

        public string PackageName { get; set; }

        public object ProcessorEntityType { get; set; }

        public DateTime CreatedDateTime { get; set; }

        public DateTime ModifiedDateTime { get; set; }

        public int CreatedByPersonAliasId { get; set; }

        public int ModifiedByPersonAliasId { get; set; }

        public bool ModifiedAuditValuesAlreadyUpdated { get; set; }

        public string Guid { get; set; }

        public int ForeignId { get; set; }

        public string ForeignGuid { get; set; }

        public string ForeignKey { get; set; }
    }
}
