using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GalyameevMR.Sprint0.TaskReview.V0.Lib;

namespace Tyuiu.GalyameevMR.Sprint0.TaskReview.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            int x = 2;
            int y = 3;
            int z = 6;
            int p = (x + y + z) * 5;
            Assert.AreEqual(55, p);
        }
    }
}
