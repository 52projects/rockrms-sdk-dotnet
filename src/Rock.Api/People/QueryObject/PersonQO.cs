using System.Reflection;
using Rock.Api.Attributes;
using System.Collections.Generic;

namespace Rock.Api.People.QueryObject {
    public class PersonQO : BaseQO {
        public PersonQO() {
            this.ExpandEntities.Add("PhoneNumbers");
            PersonIDs = new List<int>();
        }
        [QOIgnore()]
        public int? ID { get; set; }

        [QOIgnore()]
        public int? AliasID { get; set; }

        [QOIgnore()]
        public List<int> PersonIDs { get; set; }

        /// <summary>
        /// The name search parameter will be parsed by space and by comma
        /// If a space is found first, search assumes FirstName and then Last Name
        /// If comma is cound first, search assumes Last Name and then First Name
        /// expectable search criteria would be: 
        /// 'john doe', 'doe, john', 'jo do', 'do, jo'
        /// </summary>
        [QOIgnore()]
        public string Name { get; set; }

        [QOIgnore()]
        public string MiddleName { get; set; }

        [QOIgnore()]
        public string Email { get; set; }

        [QO("loadAttributes")]
        public bool? LoadAttributes { get; set; }

        /// <summary>
        /// After the search options have been created, a filter is created to send to Rock
        /// </summary>
        [QO("$filter")]
        public string Filter {
            get {
                var filterList = new List<string>();
                if (this.ID.HasValue) {
                    filterList.Add("Id eq " + this.ID.Value);
                }
                if (!string.IsNullOrEmpty(this.Email)) {
                    filterList.Add("Email eq '" + this.Email + "'");
                }
                if (AliasID.HasValue) {
                    filterList.Add("PrimaryAliasId eq " + AliasID.Value);
                }
                if (!string.IsNullOrEmpty(MiddleName)) {
                    filterList.Add("startswith(MiddleName, '" + this.MiddleName + "')");
                }
                if (!string.IsNullOrEmpty(this.Name)) {
                    var commaIndex = this.Name.IndexOf(',');
                    var spaceIndex = this.Name.IndexOf(' ');

                    // Only one word so assume first name
                    if (commaIndex < 0 && spaceIndex < 0) {
                        filterList.Add("startswith(FirstName, '" + this.Name + "')");
                    }
                    else {
                        if (commaIndex > 0 && commaIndex < spaceIndex) {
                            var commaSplitName = this.Name.Split(',');
                            filterList.Add("startswith(LastName, '" + commaSplitName[0].Trim() + "')");
                            if (commaSplitName.Length > 1 && !string.IsNullOrEmpty(commaSplitName[1])) {
                                filterList.Add("startswith(FirstName, '" + commaSplitName[1].Trim() + "')");
                            }
                        }
                        else {
                            var spaceSplitName = this.Name.Split(' ');
                            filterList.Add("startswith(FirstName, '" + spaceSplitName[0].Trim() + "')");
                            if (spaceSplitName.Length > 1 && !string.IsNullOrEmpty(spaceSplitName[1])) {
                                filterList.Add("startswith(LastName, '" + spaceSplitName[1].Trim() + "')");
                            }
                        }
                    }
                }
                if (PersonIDs.Count > 0) {
                    filterList.Add(string.Format("Id in ({0})", string.Join(",", PersonIDs)));
                }

                return string.Join(" and ", filterList);
            }
        }
    }
}
