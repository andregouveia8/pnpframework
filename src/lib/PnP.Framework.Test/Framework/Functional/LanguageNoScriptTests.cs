﻿using Microsoft.SharePoint.Client;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PnP.Framework.Enums;
using PnP.Framework.Provisioning.Model;
using PnP.Framework.Provisioning.ObjectHandlers;
using PnP.Framework.Tests.Framework.Functional.Implementation;
using PnP.Framework.Tests.Framework.Functional.Validators;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using System.Xml.XPath;

namespace PnP.Framework.Tests.Framework.Functional
{
    /// <summary>
    /// Test cases for the provisioning engine web settings functionality
    /// </summary>
    [TestClass]
    public class LanguageNoScriptTests : FunctionalTestBase
    {
        #region Construction
        public LanguageNoScriptTests()
        {
            //debugMode = true;
            //centralSiteCollectionUrl = "https://bertonline.sharepoint.com/sites/TestPnPSC_12345_6963f04e-da9d-4551-a823-94482982f862";
            //centralSubSiteUrl = "https://bertonline.sharepoint.com/sites/TestPnPSC_12345_6963f04e-da9d-4551-a823-94482982f862/sub";
        }
        #endregion

        #region Test setup
        [ClassInitialize()]
        public static void ClassInit(TestContext context)
        {
            ClassInitBase(context, true);
        }

        [ClassCleanup()]
        public static void ClassCleanup()
        {
            ClassCleanupBase();
        }
        #endregion

        #region Site collection test cases
        /// <summary>
        /// Site LanguageSettings Test
        /// </summary>
        [TestMethod]
        [Timeout(15 * 60 * 1000)]
        public void SiteCollectionLanguageSettingsTest()
        {
            new LanguageImplementation().SiteCollectionLanguageSettings(centralSiteCollectionUrl);
        }
        #endregion

        #region Web test cases
        /// <summary>
        /// Web WebSettings test
        /// </summary>
        [TestMethod]
        [Timeout(15 * 60 * 1000)]
        public void WebLanguageSettingsTest()
        {
            new LanguageImplementation().SiteCollectionLanguageSettings(centralSubSiteUrl);
        }
        #endregion
    }
}
