using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.GalyameevMR.Sprint0.Task4.V0.Lib;

namespace Tyuiu.GalyameevMR.Sprint0.Task4.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DataService.Sum(1, 2));
            Console.WriteLine(DataService.Razn(6, 3));
            Console.WriteLine(DataService.Proizv(5, 4));
            Console.WriteLine(DataService.Chastn(4, 2));
            Console.ReadKey();
        }
    }
}
