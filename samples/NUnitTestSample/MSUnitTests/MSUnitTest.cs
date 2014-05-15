using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnitTestSample;


namespace MSUnitTests
{
    [TestClass]
    public class MSUnitTest
    {
            [TestMethod]
            public void Add()
            {
                MathsHelper helper = new MathsHelper();
                int result = helper.Add(20, 10);

                // Check if the add function return 30 

                Assert.AreEqual(result,30);                         
            }
        
            [TestMethod]
            public void Sub()
            {
                MathsHelper helper = new MathsHelper();
                int result = helper.Subtract(20, 10);

                // Check if the sub function return 10 

                Assert.AreEqual(result,10);
            }
    }
}

