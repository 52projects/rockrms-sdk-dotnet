using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rock.Api.Model;
using System.Xml;
using System.Xml.Serialization;

namespace Rock.Api.People.Model {
    public class Person : ApiModel {
        public string Guid { get; set; }
        public int? ForeignId { get; set; }
        public string ForeignGuid { get; set; }
        public string ForeignKey { get; set; }
        public bool IsSystem { get; set; }
        public int? RecordTypeValueId { get; set; }
        public int? RecordStatusValueId { get; set; }
        public DateTime? RecordStatusLastModifiedDateTime { get; set; }
        public int? RecordStatusReasonValueId { get; set; }
        public int? ConnectionStatusValueId { get; set; }
        public int? ReviewReasonValueId { get; set; }
        public bool IsDeceased { get; set; }
        public int TitleValueId { get; set; }
        public string FirstName { get; set; }
        public string NickName { get; set; }

        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public int? SuffixValueId { get; set; }
        public int? PhotoId { get; set; }
        public int? BirthDay { get; set; }
        public int? BirthMonth { get; set; }
        public int? BirthYear { get; set; }
        public int? Gender { get; set; }

        public int? MaritalStatusValueId { get; set; }
        public DateTime? AnniversaryDate { get; set; }
        public int? GraduationYear { get; set; }
        public int? GivingGroupId { get; set; }
        public string GivingId { get; set; }
        public int? GivingLeaderId { get; set; }
        public string Email { get; set; }
        public bool IsEmailActive { get; set; }
        public string EmailNote { get; set; }
        public int? EmailPreference { get; set; }
        public string ReviewReasonNote { get; set; }
        public string InactiveReasonNote { get; set; }
        public string SystemNote { get; set; }
        public int? ViewCount { get; set; }
        public int? PrimaryAliasId { get; set; }
        public List<string> Users { get; set; }
        public List<string> PhoneNumbers { get; set; }

        [XmlIgnore]
        public DateTime? BirthDate {
            get {
                if (BirthYear.HasValue) {
                    return new DateTime(BirthYear.Value, BirthMonth.Value, BirthDay.Value);
                }

                return null;
            }
        }
    }
}
