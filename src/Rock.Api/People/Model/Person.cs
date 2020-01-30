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
    public class Person : AttributeApiModel {
        public Person() {
            this.EmailPreference = EmailPreference.EmailAllowed;
            this.Gender = Gender.Unknown;
            _gender = Gender.Unknown;
            this.PhoneNumbers = new List<PhoneNumber>();
            AttributeValueList = new List<AttributeValue>();
        }

        public bool IsSystem { get; set; }

        public int? RecordTypeValueId { get; set; }

        public int? RecordStatusValueId { get; set; }

        public DateTime? RecordStatusLastModifiedDateTime { get; set; }

        public int? RecordStatusReasonValueId { get; set; }

        public int? ConnectionStatusValueId { get; set; }

        public int? ReviewReasonValueId { get; set; }

        public bool IsDeceased { get; set; }

        private int? _titleValueId;
        public int? TitleValueId { 
            get => _titleValueId;
            set {
                _titleValueId = value;
                TrackProperty("TitleValueId", value);
            }
        }

        private string _firstName;
        public string FirstName {
            get {
                return _firstName;
            }
            set {
                _firstName = value;
                TrackProperty("FirstName", value);
            }
        }

        private string _nickName;
        public string NickName {
            get {
                return _nickName;
            }
            set {
                _nickName = value;
                TrackProperty("NickName", value);
            }
        }

        private string _middleName;
        public string MiddleName {
            get {
                return _middleName;
            }
            set {
                _middleName = value;
                TrackProperty("MiddleName", value);
            }
        }

        private string _lastName;
        public string LastName {
            get {
                return _lastName;
            }
            set {
                _lastName = value;
                TrackProperty("LastName", value);
            }
        }

        public int? SuffixValueId { get; set; }

        public int? PhotoId { get; set; }

        public int? BirthDay { get; set; }

        public int? BirthMonth { get; set; }

        public int? BirthYear { get; set; }

        private Gender _gender;
        public Gender Gender {
            get {
                return _gender;
            }
            set {
                _gender = value;
                TrackProperty("Gender", value);
            }
        }

        public int? MaritalStatusValueId { get; set; }

        public DateTime? AnniversaryDate { get; set; }

        public int? GraduationYear { get; set; }

        public int? GivingGroupId { get; set; }

        public string GivingId { get; set; }

        public int GivingLeaderId { get; set; }

        private string _email;
        public string Email {
            get {
                return _email;
            }
            set {
                _email = value;
                TrackProperty("Email", value);
            }
        }

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

        [JsonIgnore()]
        public List<AttributeValue> AttributeValueList { get; set; }

        private DateTime? _birthDate;
        public DateTime? BirthDate {
            get {
                return _birthDate;
            }
            set {
                _birthDate = value;

                TrackProperty("BirthDay", value == null ? (int?)null : value.Value.Day);
                TrackProperty("BirthMonth", value == null ? (int?)null : value.Value.Month);
                TrackProperty("BirthYear", value == null ? (int?)null : value.Value.Year);
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
