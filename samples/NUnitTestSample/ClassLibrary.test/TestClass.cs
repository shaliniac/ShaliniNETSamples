using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using NUnit;
using NUnitTestSample;

namespace ClassLibrary.test
{
    [TestFixture]
    public class TestClass
    {
        // Test the add method
        [TestCase]
        public void AddTest()
        {
            MathsHelper helper = new MathsHelper();
            int result = helper.Add(20, 10);

            // Check if the add function return 30 
            Assert.AreEqual(30, result);
        }
        // Test subtract method
        [TestCase]
        public void SubtractTest()
        {
            MathsHelper helper = new MathsHelper();
            int result = helper.Subtract(20, 10);
            // Check if the subtract function return 10 
            Assert.AreEqual(10, result);
        }


    }
}
