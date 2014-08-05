using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WorldNomads.Utility;

namespace WorldNomads.UnitTest
{
    [TestClass]
    public class GetOddNumbers
    {
        [TestMethod]
        public void GetOddNumbers_Negative()
        {
            var result = IntegerParser.GetOddNumbers(-100);
            Assert.AreEqual(string.Empty, result);
        }

        [TestMethod]
        public void GetOddNumbers_Zero()
        {
            var result = IntegerParser.GetOddNumbers(0);
            Assert.AreEqual(string.Empty, result);
        }

        [TestMethod]
        public void GetOddNumbers_Positive()
        {
            var result = IntegerParser.GetOddNumbers(300);
            var array = result.Split(',');
            Assert.AreEqual(150, array.Length);
            Assert.AreEqual("1", array[0]);
            Assert.AreEqual("299", array[149]);
        }
    }
}
