using Rock.Api.Model;
using System;

namespace Rock.Api.Financial.Model {
    public class Account : ApiModel {
        public int? ParentAccountId { get; set; }

        public int? CampusId { get; set; }

        public string Name { get; set; }

        public string PublicName { get; set; }

        public string Description { get; set; }

        public bool IsTaxDeductible { get; set; }

        public string GlCode { get; set; }

        public int Order { get; set; }

        public bool IsActive { get; set; }

        public bool IsPublic { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public int? AccountTypeValueId { get; set; }

        public int? ImageBinaryFileId { get; set; }

        public string Url { get; set; }

        public string AccountTypeValue { get; set; }

        public string ImageBinaryFile { get; set; }

        public DateTime? CreatedDateTime { get; set; }

        public DateTime? ModifiedDateTime { get; set; }
    }
}
