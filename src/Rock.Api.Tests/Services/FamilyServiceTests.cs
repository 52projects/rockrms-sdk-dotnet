using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Shouldly;
using Rock.Api.People.Model;

namespace Rock.Api.Tests.Services {
    [TestFixture]
    public class FamilyServiceTests : Base {
        [Test]
        public void family_service_create_family() {
            var family = new Family {
                Name = "Meyer Family",
                HomeLocation = new Location {
                    Street1 = "123 Test Rd",
                    Street2 = "",
                    State = "TX",
                    City = "Georgetown",
                    Country = "USA"
                },
                MainPhone = new PhoneNumber {
                    Number = "1231231234",
                    NumberTypeValueId = 1
                }
            };

            family.FamilyMembers.Add(new FamilyMember {
                Person = new Person {
                    FirstName = "Colin",
                    LastName = "Meyer",
                    Email = "chadmeyer@me.com",
                    Gender = Api.People.Enum.Gender.Male,
                    ConnectionStatusValueId = 65
                }
            });
            family.FamilyMembers.Add(new FamilyMember {
                Person = new Person {
                    FirstName = "Haley",
                    LastName = "Meyer",
                    Email = "haleyb07@me.com",
                    Gender = Api.People.Enum.Gender.Female,
                    ConnectionStatusValueId = 65
                }
            });
            var familyResult = FamilyService.CreateFamily(family);
            familyResult.Data.ShouldBeGreaterThan(0);
        }
    }
}
