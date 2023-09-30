using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GalyameevMR.Sprint0.Task6.V0.Lib;
namespace Tyuiu.GalyameevMR.Sprint0.Task6.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckAdditionArrayValid()
        {
        var numbers = new int[] { 1, 2, 3, 4, 5 };
        var res = DataService.AdditionArray(numbers);
        }

        [TestMethod]
        public void ChecSubstractionArrayValid()
        {
            var numbers = new int[] { 1, 2, 3, 4, 5 };
            var res = DataService.SubtractionArray((numbers));
        }

        [TestMethod]
        public void CheckMultiplicationArrayValid()
        {
            var numbers = new int[] { 1, 2, 3, 4, 5 };
            var res = DataService.MultiplicationArray((numbers));
        }
    }
}
