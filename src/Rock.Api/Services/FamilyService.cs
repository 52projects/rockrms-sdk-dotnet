using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rock.Api.Model;
using Rock.Api.People.Model;
using Rock.Api.Groups.Model;

namespace Rock.Api.Services {
    public interface IFamilyService {
        /// <summary>
        /// Creates a family in Rock 
        /// </summary>
        /// <param name="family"></param>
        /// <returns>The family ID</returns>
        IRockResponse<int> CreateFamily(Family family);

        /// <summary>
        /// Create a person in Rock and then add the person to the family
        /// </summary>
        /// <param name="person"></param>
        /// <param name="familyId"></param>
        /// <returns></returns>
        IRockResponse<int> AddToFamily(Person person, int familyId);
    }

    public class FamilyService : BaseService, IFamilyService {
        public FamilyService(string domainUrl, string apiToken) : base(domainUrl, apiToken) {
            
        }

        public IRockResponse<int> CreateFamily(Family family) {
            var group = new Group {
                GroupTypeId = 10, // Family Group Type
                Name = family.Name,
                IsActive = true,
                IsPublic = true,
            };
            var groupResult = RockClient.GroupRealm.Groups.Create(group);
            if (groupResult.Data <= 0) {
                return groupResult;
            }

            if (family.HomeLocation != null) {
                var locationTypeResults = RockClient.GeneralRealm.DefinedValues.FindByType(General.Enum.SystemDefinedType.GroupLocationType);
                var locationType = locationTypeResults.Data.Items.Where(x => x.Value.Contains("Home")).FirstOrDefault();
                if (locationType == null) {
                    locationType = locationTypeResults.Data.Items[0];
                }

                family.HomeLocation.LocationTypeValueId = locationType.Id;
                var locationResult = RockClient.PeopleRealm.Locations.Create(family.HomeLocation);
                if (locationResult.Data > 0) {
                    var groupLocation = new GroupLocation {
                        GroupId = groupResult.Data,
                        LocationId = locationResult.Data,
                        IsMailingLocation = true,
                        IsMappedLocation = true,
                        GroupLocationTypeValueId = locationType.Id
                    };

                    var groupLocationResult = RockClient.GroupRealm.GroupLocations.Create(groupLocation);
                }
            }

            if (family.FamilyMembers.Count > 0) {
                foreach (var member in family.FamilyMembers) {
                    var personResult = AddToFamily(member.Person, groupResult.Data);
                }
            }

            return groupResult;
        }

        public IRockResponse<int> AddToFamily(Person person, int familyId) {
            var personResult = RockClient.PeopleRealm.People.Create(person);

            if (personResult.Data > 0) {
                var groupMember = new GroupMember {
                    GroupId = familyId,
                    PersonId = personResult.Data,
                    GroupMemberStatus = 1,
                    GroupRoleId = 3
                };

                var groupMemberResult = RockClient.GroupRealm.GroupMembers.Create(groupMember);
            }

            return personResult;
        }
    }
}
