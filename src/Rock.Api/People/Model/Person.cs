using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rock.Api.Model;
using System.Xml;
using System.Xml.Serialization;
using Rock.Api.People.Enum;
using Newtonsoft.Json;
using Rock.Api.General.Model;

namespace Rock.Api.People.Model {
    public class Person : ApiModel {
        public Person() {
            this.EmailPreference = EmailPreference.EmailAllowed;
            this.Gender = Gender.Unknown;
            this.PhoneNumbers = new List<PhoneNumber>();
            AttributeValues = new List<AttributeValue>();
        }

        public bool IsSystem { get; set; }

        public int? RecordTypeValueId { get; set; }

        public int? RecordStatusValueId { get; set; }

        public DateTime? RecordStatusLastModifiedDateTime { get; set; }

        public int? RecordStatusReasonValueId { get; set; }

        public int? ConnectionStatusValueId { get; set; }

        public int? ReviewReasonValueId { get; set; }

        public bool IsDeceased { get; set; }

        public int? TitleValueId { get; set; }

        public string FirstName { get; set; }

        public string NickName { get; set; }

        public string MiddleName { get; set; }

        public string LastName { get; set; }
        public int? SuffixValueId { get; set; }
        public int? PhotoId { get; set; }
        public int? BirthDay { get; set; }
        public int? BirthMonth { get; set; }
        public int? BirthYear { get; set; }
        public Gender Gender { get; set; }
        public int? MaritalStatusValueId { get; set; }
        public DateTime? AnniversaryDate { get; set; }
        public int? GraduationYear { get; set; }
        public int? GivingGroupId { get; set; }
        public string GivingId { get; set; }
        public int GivingLeaderId { get; set; }
        public string Email { get; set; }
        public bool IsEmailActive { get; set; }
        public string EmailNote { get; set; }
        public EmailPreference EmailPreference { get; set; }

        public CommunicationType CommunicationPreference { get; set; }

        public string ReviewReasonNote { get; set; }
        public string InactiveReasonNote { get; set; }
        public string SystemNote { get; set; }
        public int? ViewedCount { get; set; }

        public string TopSignalColor { get; set; }

        public string TopSignalIconCssClass { get; set; }

        public int? TopSignalId { get; set; }

        public AgeClassification AgeClassification { get; set; }

        public bool IsLockedAsChild { get; set; }

        public int? PrimaryFamilyId { get; set; }

        public DateTime? DeceasedDate { get; set; }

        public int? PrimaryAliasId { get; set; }

        public List<string> Users { get; set; }

        public List<PhoneNumber> PhoneNumbers { get; set; }

        [JsonIgnore]
        public List<AttributeValue> AttributeValues { get; set; }

        [XmlIgnore]
        [JsonIgnore]
        public DateTime? BirthDate {
            get {
                if (BirthYear.HasValue) {
                    return new DateTime(BirthYear.Value, BirthMonth.Value, BirthDay.Value);
                }

                return null;
            }
        }

        public bool ShouldSerializeGivingLeaderId() {
            return false;
        }

        public bool ShouldSerializeUsers() {
            return false;
        }

        public bool ShouldSerializePhoneNumbers() {
            return false;
        }
    }
}
