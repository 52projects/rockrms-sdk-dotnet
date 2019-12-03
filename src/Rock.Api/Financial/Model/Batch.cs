using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock.Api.Financial.Model {
    public class Batch {
        public string Name { get; set; }

        public DateTime BatchStartDateTime { get; set; }

        public DateTime BatchEndDateTime { get; set; }

        public int Status { get; set; }

        public bool IsAutomated { get; set; }

        public int? CampusId { get; set; }

        public string AccountingSystemCode { get; set; }

        public decimal ControlAmount { get; set; }

        public string Note { get; set; }

        public int Id { get; set; }
    }
}
