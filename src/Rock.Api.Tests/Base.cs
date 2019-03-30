using System;
using NUnit;
using NUnit.Framework;
using Rock.Api;
using Rock.Api.Services;

namespace Rock.Api.Tests {
    [TestFixture]
    public class Base {
        private const string _apiToken = "Kd8LicOdwqGkqyO1prcERm8c";
        private const string _domainUrl = "http://rock.rocksolidchurchdemo.com";
        internal RockClient RockClient;
        internal IFamilyService FamilyService;

        [OneTimeSetUp]
        public void Setup() {
            this.RockClient = new RockClient(_domainUrl, _apiToken);
            FamilyService = new FamilyService(_domainUrl, _apiToken);
        }
    }
}
