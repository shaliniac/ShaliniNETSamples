using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Moq;
using RichieCreativeUniversity.DAL;



namespace RichieCreativeUniversity.Tests.Controllers
{
    [TestClass]
    public class StudentControllerTest
    {

        [TestMethod]
        public void Create(SchoolContext _context)
        {
            var data = new List<_context.> 
            { 
                new account { username = "test",pass="hello" }, 
                new account { username = "ZZZ",pass="testpass2" }, 
                new account { username = "AAA",pass="testpass3" }, 
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

            var mockContext = new Mock<DatabaseContext>();
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
}
