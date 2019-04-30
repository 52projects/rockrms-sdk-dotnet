using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rock.Api.Model;

namespace Rock.Api.General.Model {

    public class Attribute : ApiModel {
        public bool IsSystem { get; set; }

        public int FieldTypeId { get; set; }

        public int EntityTypeId { get; set; }

        public string EntityTypeQualifierColumn { get; set; }

        public string EntityTypeQualifierValue { get; set; }

        public string Key { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public int Order { get; set; }

        public bool IsGridColumn { get; set; }

        public string DefaultValue { get; set; }

        public bool IsMultiValue { get; set; }

        public bool IsRequired { get; set; }

        public object IconCssClass { get; set; }

        public bool AllowSearch { get; set; }

        public bool IsIndexEnabled { get; set; }

        public bool IsAnalytic { get; set; }

        public bool IsAnalyticHistory { get; set; }

        public bool IsActive { get; set; }

        public bool EnableHistory { get; set; }

        public object EntityType { get; set; }

        public object FieldType { get; set; }

        public object CreatedDateTime { get; set; }

        public object ModifiedDateTime { get; set; }

        public object CreatedByPersonAliasId { get; set; }

        public object ModifiedByPersonAliasId { get; set; }

        public bool ModifiedAuditValuesAlreadyUpdated { get; set; }

        public string Guid { get; set; }

        public object ForeignId { get; set; }

        public object ForeignGuid { get; set; }

        public object ForeignKey { get; set; }
    }

}
