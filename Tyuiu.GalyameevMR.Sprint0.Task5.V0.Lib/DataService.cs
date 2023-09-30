using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.GalyameevMR.Sprint0.Task5.V0.Lib
{
    public class DataService
    {

        public static int Sum(int a, int b)
        {
            return a + b;
        }

        public static int Razn(int a, int b)
        {
            return a - b;
        }

        public static int Proiz(int a, int b)
        {
            return a * b;
        }

        public static float Chastn(int a, int b)
        {
            if (b == 0)
            {
                Console.WriteLine("На ноль делить нельзя!");
                return -1;
            }
            else
            {
                return a/b;
            }

        }
    }
}



