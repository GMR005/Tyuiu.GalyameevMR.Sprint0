using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GalyameevMR.Sprint0.Task3.V0.Lib;

namespace Tyuiu.GalyameevMR.Sprint0.Task3.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ChekedValid()
        {
            Assert.AreEqual(10, DataService.Sum(5, 5));

        }
    }
}
