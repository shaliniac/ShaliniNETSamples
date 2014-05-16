using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FunctionsClassLibrary;

namespace UnitTestFizzBuzz
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void Fizz()
        {
            //Arrange
            FizzBuzzMethods findFizzBuzz = new FizzBuzzMethods();

            //Action
            bool result = findFizzBuzz.Fizz(3);

            // Assert Check if the Fizz function return true 

            Assert.AreEqual(result, true);
        }

        [TestMethod]
        public void Buzz()
        {
            //Arrange
            FizzBuzzMethods findFizzBuzz = new FizzBuzzMethods();

            //Action
            bool result = findFizzBuzz.Buzz(5);

            // Assert Check if the Buzz function return true 

            Assert.AreEqual(result, true);
        }        
    }
}
