using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Moq;
using DatabaseTestConsole;



namespace DatabaseTestConsoleTests
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestQuery()
        {
            var data = new List<account> 
            { 
                new account { username = "test",password="testpass1" }, 
                new account { username = "ZZZ",password="testpass2" }, 
                new account { username = "AAA",password="testpass3" }, 
            }.AsQueryable();

            var mockSet = new Mock<DbSet<account>>();
            mockSet.As<IQueryable<account>>().Setup(m => m.Provider)
                   .Returns(data.Provider);
            mockSet.As<IQueryable<account>>().Setup(m => m.Expression)
                   .Returns(data.Expression);
            mockSet.As<IQueryable<account>>().Setup(m => m.ElementType)
                   .Returns(data.ElementType);
            mockSet.As<IQueryable<account>>().Setup(m => m.GetEnumerator())
                   .Returns(data.GetEnumerator());

            var mockContext = new Mock<accountdbEntities>();
            mockContext.Setup(c => c.accounts).Returns(mockSet.Object);

            UserRights rights = new UserRights(mockContext.Object);

            Assert.AreEqual("testpass1", rights.LookupPassword("test"),
                  "password for account test is incorrect");
            Assert.AreEqual("testpass2", rights.LookupPassword("ZZZ"),
                  "password for account ZZZ is incorrect");
            Assert.AreEqual("testpass3", rights.LookupPassword("AAA"),
                  "password for account AAA is incorrect");
        }

    }
}
