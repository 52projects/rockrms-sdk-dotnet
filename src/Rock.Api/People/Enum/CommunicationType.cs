using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock.Api.People.Enum {
    public enum CommunicationType {
        RecipientPreference = 0x0,
        Email = 0x1,
        SMS = 0x2,
        PushNotification = 0x3
    }
}
