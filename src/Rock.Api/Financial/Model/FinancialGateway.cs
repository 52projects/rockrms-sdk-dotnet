using Rock.Api.Model;
using System;

namespace Rock.Api.Financial.Model {
    public class FinancialGateway : ApiModel {
        public string Description { get; set; }

        public int EntityTypeId { get; set; }

        public bool IsActive { get; set; }

        public string Name { get; set; }
    }
}