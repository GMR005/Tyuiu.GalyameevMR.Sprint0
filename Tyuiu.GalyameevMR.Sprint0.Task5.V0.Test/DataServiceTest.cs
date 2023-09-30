using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GalyameevMR.Sprint0.Task5.V0.Lib;

namespace Tyuiu.GalyameevMR.Sprint0.Task5.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
         public void SumValid ()
         {
           Assert.AreEqual(8, DataService.Sum(4, 4));
         }

        [TestMethod]
        public void RaznValid()
        {
            Assert.AreEqual(0, DataService.Sum(4, 4));
        }

        [TestMethod]
        public void ProizValid()
        {
            Assert.AreEqual(16, DataService.Sum(4, 4));
        }

        [TestMethod]
        public void ChastnValid()
        {
            Assert.AreEqual(1, DataService.Sum(4, 4));
        }

    
    }
}
