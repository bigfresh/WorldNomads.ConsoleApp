using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WorldNomads.Utility;

namespace WorldNomads.UnitTest
{
    [TestClass]
    public class GetSpecialNumbers
    {
        [TestMethod]
        public void GetSpecialNumbers_Negative()
        {
            var result = IntegerParser.GetSpecialNumbers(-9);
            Assert.AreEqual(string.Empty, result);
        }

        [TestMethod]
        public void GetSpecialNumbers_Zero()
        {
            var result = IntegerParser.GetSpecialNumbers(0);
            Assert.AreEqual("0", result);
        }

        [TestMethod]
        public void GetSpecialNumbers_Positive()
        {
            var result = IntegerParser.GetSpecialNumbers(100);
            var array = result.Split(',');
            Assert.AreEqual(101, array.Length);
            Assert.AreEqual("0", array[0]);
            Assert.AreEqual("1", array[1]);
            Assert.AreEqual("fizz", array[3]);
            Assert.AreEqual("buzz", array[5]);
            Assert.AreEqual("fizz", array[9]);
            Assert.AreEqual("fizz buzz", array[15]);
            Assert.AreEqual("buzz", array[100]);
        }
    }
}
