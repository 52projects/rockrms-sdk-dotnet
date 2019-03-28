using Rock.Api.Model;
using System;


namespace Rock.Api.Financial.Model {
    public class Pledge : ApiModel {
        public int PersonAliasId { get; set; }

        public int? GroupId { get; set; }

        public int AccountId { get; set; }

        public int PledgeFrequencyValueId { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public string PledgeFrequencyValue { get; set; }

        public DateTime CreatedDateTime { get; set; }

        public DateTime ModifiedDateTime { get; set; }
    }
}