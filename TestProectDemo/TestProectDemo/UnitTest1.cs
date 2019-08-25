using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProectDemo
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string expected = "Testing";
            string actual = "Testing";
            Assert.AreEqual(expected, actual);
        }
    }
}
