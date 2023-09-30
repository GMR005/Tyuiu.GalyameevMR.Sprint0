using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.GalyameevMR.Sprint0.Task5.V0.Lib;
namespace Tyuiu.GalyameevMR.Sprint0.Task5.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A + B = " + DataService.Sum(7, 8));
            Console.WriteLine("A - B = " + DataService.Razn(9, 5));
            Console.WriteLine("A * B = " + DataService.Proiz(7, 8));
            Console.WriteLine("A / B = " + DataService.Chastn(6, 0));
            Console.ReadKey();
        }
    }
}
