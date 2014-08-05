using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WorldNomads.Utility;

namespace WorldNomads.UnitTest
{
    [TestClass]
    public class GetFibonacciNumbers
    {
        [TestMethod]
        public void GetFibonacciNumbers_Negative()
        {
            var result = IntegerParser.GetFibonacciNumbers(-10);
            Assert.AreEqual(string.Empty, result);
        }

        [TestMethod]
        public void GetFibonacciNumbers_Zero()
        {
            var result = IntegerParser.GetFibonacciNumbers(0);
            Assert.AreEqual("0", result);
        }

        [TestMethod]
        public void GetFibonacciNumbers_Positive()
        {
            var result = IntegerParser.GetFibonacciNumbers(395);
            var array = result.Split(',');
            Assert.AreEqual(15, array.Length);
            Assert.AreEqual("0", array[0]);
            Assert.AreEqual("377", array[14]);
        }
    }
}
