using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GalyameevMR.Sprint0.Task7.V0.Lib;

namespace Tyuiu.GalyameevMR.Sprint0.Task7.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckAdditionArrays()
        {
           
            
                int[] numOne = new int[] { 1, 1, 1, 1, 1 };
                int[] numTwo = new int[] { 1, 1, 1, 1, 1 };
                int[] numThree = new int[] { 2, 2, 2, 2, 2 };

                int[] res = DataService.AdditionArrays(numOne, numTwo);
                CollectionAssert.AreEqual(numThree, res);
            
        }
    }
}
