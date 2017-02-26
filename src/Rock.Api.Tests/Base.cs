﻿using System;
using NUnit;
using NUnit.Framework;
using Rock.Api;

namespace Rock.Api.Tests {
    [TestFixture]
    public class Base {
        private const string _apiToken = "EPNhFAW7vLgHDKj1vm9SQREv";
        private const string _domainUrl = "http://rock.rocksolidchurchdemo.com";
        public RockClient RockClient;
        [OneTimeSetUp]
        public void Setup() {
            this.RockClient = new RockClient(_domainUrl, _apiToken);
        }
    }
}
