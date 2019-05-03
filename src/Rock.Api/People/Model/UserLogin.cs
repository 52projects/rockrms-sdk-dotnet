using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock.Api.People.Model {

    public class UserLogin {
        public int EntityTypeId { get; set; }

        public string UserName { get; set; }

        public bool IsConfirmed { get; set; }

        public DateTime LastActivityDateTime { get; set; }

        public DateTime LastLoginDateTime { get; set; }

        public DateTime LastPasswordChangedDateTime { get; set; }

        public bool IsOnLine { get; set; }

        public object IsLockedOut { get; set; }

        public object IsPasswordChangeRequired { get; set; }

        public DateTime LastLockedOutDateTime { get; set; }

        public int FailedPasswordAttemptCount { get; set; }

        public DateTime FailedPasswordAttemptWindowStartDateTime { get; set; }

        public object LastPasswordExpirationWarningDateTime { get; set; }

        public string ApiKey { get; set; }

        public int PersonId { get; set; }

        public object EntityType { get; set; }

        public string ConfirmationCode { get; set; }

        public string ConfirmationCodeEncoded { get; set; }

        public DateTime CreatedDateTime { get; set; }

        public DateTime ModifiedDateTime { get; set; }

        public object CreatedByPersonAliasId { get; set; }

        public object ModifiedByPersonAliasId { get; set; }
        public bool ModifiedAuditValuesAlreadyUpdated { get; set; }

        public int Id { get; set; }

        public string Guid { get; set; }
    }
}
