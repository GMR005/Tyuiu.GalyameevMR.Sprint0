using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.GalyameevMR.Sprint0.TaskReview.V0.Lib;

namespace Tyuiu.GalyameevMR.Sprint0.Review
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, z;
            int.TryParse(Console.ReadLine(), out x);
            int.TryParse(Console.ReadLine(), out y);
            int.TryParse(Console.ReadLine(), out z);
            Console.WriteLine((x + y + z) * 5);
            Console.ReadKey();
        }
    }
}
