using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GalyameevMR.Sprint0.Task4.V0.Lib;

namespace Tyuiu.GalyameevMR.Sprint0.Task4.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void SumValid()
        {
            Assert.AreEqual(12, DataService.Sum(6, 6));
        }

        [TestMethod]
        public void RaznValid()
        {
            Assert.AreEqual(0, DataService.Razn(6, 6));
        }

        [TestMethod]
        public void ProizValid()
        {
            Assert.AreEqual(36, DataService.Proizv(6, 6));
        }

        [TestMethod]
        public void ChastnValid()
        {
            Assert.AreEqual(1, DataService.Chastn(6, 6));
        }
    }
}
