using System;
using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AzureSqlUtil;

namespace FakeDataTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestGetDatabaseServers()
        {
            List<string> dbservers = FakeData.GetDatabaseServers();
            Assert.AreEqual(dbservers.Count, 2,
                $"Expected two fake database names, returned {dbservers.Count}");
            // List<string> databases = FakeData.
        }

        [TestMethod]
        public void TestGetUsers()
        {
            List<string> devusers = FakeData.GetUsers("ds3devsqlsrv1");
            Assert.IsNotNull(devusers, "returned null list of dev users");
            if (devusers != null)
            {
                Assert.AreEqual(devusers.Count, 6, "six test logins expected for dev server");
                Assert.IsFalse(devusers.Contains("e324zx"),
                    "e324zx is a prod only user, should not be in dev");
                Assert.IsTrue(devusers.Contains("e320bx"), "devusers should include e320bx");
            }
        }

        [TestMethod]
        public void TestGetDatabases()
        {
            List<string> databases = FakeData.GetDatabases("ds3devsqlsrv1");
            Assert.AreEqual(databases.Count, 2, $"dev should have two databases instead of {databases.Count}");
        }
    }
}
