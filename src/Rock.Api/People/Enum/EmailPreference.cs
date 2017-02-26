using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock.Api.People.Enum {
    /// <summary>
    /// The person's email preference
    /// </summary>
    public enum EmailPreference {
        /// <summary>
        /// Emails can be sent to person
        /// </summary>
        EmailAllowed = 0,
        /// <summary>
        /// No Mass emails should be sent to person
        /// </summary>
        NoMassEmails = 1,
        /// <summary>
        /// No emails should be sent to person
        /// </summary>
        DoNotEmail = 2
    }
}
