using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Moq;
using PhoneDirectoryApp;

namespace MoqUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //PhoneNumber is the name of my table which stores name and phone numbers

            var data = new List<PhoneNumber> 
            { 
                new PhoneNumber {Name = "Ani",Number="123" }, 
                new PhoneNumber { Name = "Kevin",Number="1234"  }               
            }.AsQueryable();

            //Arrange pass the database set to The Mock Database Table 
            var mockSet = new Mock<DbSet<PhoneNumber>>();
            mockSet.As<IQueryable<PhoneNumber>>().Setup(m => m.Provider)
                   .Returns(data.Provider);
            mockSet.As<IQueryable<PhoneNumber>>().Setup(m => m.Expression)
                   .Returns(data.Expression);
            mockSet.As<IQueryable<PhoneNumber>>().Setup(m => m.ElementType)
                   .Returns(data.ElementType);
            mockSet.As<IQueryable<PhoneNumber>>().Setup(m => m.GetEnumerator())
                   .Returns(data.GetEnumerator());

            var mockContext = new Mock<PhoneDirectoryEntities>();
            mockContext.Setup(c => c.PhoneNumbers).Returns(mockSet.Object);

            //Act Pass the mocked objects to the class FindPhoneNumbeR
            FindPhoneNumber find = new FindPhoneNumber(mockContext.Object);

            //Assert Find if the number returned for each person is the expected value
            Assert.AreEqual("123", find.LookupNumber("Ani"));
            Assert.AreEqual("1234", find.LookupNumber("Kevin"));
        }
    }
}

