using System;
using NUnit;
using NUnit.Framework;
using Rock.Api;

namespace Rock.Api.Tests {
    [TestFixture]
    public class Base {
        private const string _apiToken = "2prRCuo9fEXeFuWs1Gl6EiTQ";
        private const string _domainUrl = "http://localhost:6229";
        internal RockClient RockClient;

        [OneTimeSetUp]
        public void Setup() {
            this.RockClient = new RockClient(_domainUrl, _apiToken);
        }
    }
}
