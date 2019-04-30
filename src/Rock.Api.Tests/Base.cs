﻿using System;
using NUnit;
using NUnit.Framework;
using Rock.Api;

namespace Rock.Api.Tests {
    [TestFixture]
    public class Base {
        private const string _apiToken = "Kd8LicOdwqGkqyO1prcERm8c";
        private const string _domainUrl = "https://rock.dev.focusmissions.com";
        internal RockClient RockClient;

        [OneTimeSetUp]
        public void Setup() {
            this.RockClient = new RockClient(_domainUrl, _apiToken);
        }
    }
}
