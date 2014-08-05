using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WorldNomads.Utility;

namespace WorldNomads.UnitTest
{
    [TestClass]
    public class GetAllNumbers
    {
        [TestMethod]
        public void GetAllNumbers_Negative()
        {
            var result = IntegerParser.GetAllNumbers(-100);
            Assert.AreEqual(string.Empty, result);
        }

        [TestMethod]
        public void GetAllNumbers_Zero()
        {
            var result = IntegerParser.GetAllNumbers(0);
            Assert.AreEqual("0", result);
        }

        [TestMethod]
        public void GetAllNumbers_Positive()
        {
            var result = IntegerParser.GetAllNumbers(360);
            var array = result.Split(',');
            Assert.AreEqual(361, array.Length);
            Assert.AreEqual("0", array[0]);
            Assert.AreEqual("360", array[360]);
        }
    }
}
