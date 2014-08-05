using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WorldNomads.Utility;

namespace WorldNomads.UnitTest
{
    [TestClass]
    public class GetEvenNumbers
    {
        [TestMethod]
        public void GetEvenNumbers_Negative()
        {
            var result = IntegerParser.GetEvenNumbers(-100);
            Assert.AreEqual(string.Empty, result);
        }

        [TestMethod]
        public void GetEvenNumbers_Zero()
        {
            var result = IntegerParser.GetEvenNumbers(0);
            Assert.AreEqual("0", result);
        }

        [TestMethod]
        public void GetEvenNumbers_Positive()
        {
            var result = IntegerParser.GetEvenNumbers(300);
            var array = result.Split(',');
            Assert.AreEqual(151, array.Length);
            Assert.AreEqual("0", array[0]);
            Assert.AreEqual("300", array[150]);
        }
    }
}
