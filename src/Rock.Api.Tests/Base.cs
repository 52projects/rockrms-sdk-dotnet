﻿using System;
using NUnit;
using NUnit.Framework;
using Rock.Api;

namespace Rock.Api.Tests {
    [TestFixture]
    public class Base {
        private const string _apiToken = "69HnfgwQyrIWqRaHh1QvGOJH";
        private const string _domainUrl = "http://rock.rocksolidchurchdemo.com";
        public RockClient RockClient;
        [OneTimeSetUp]
        public void Setup() {
            this.RockClient = new RockClient(_domainUrl, _apiToken);
        }
    }
}
