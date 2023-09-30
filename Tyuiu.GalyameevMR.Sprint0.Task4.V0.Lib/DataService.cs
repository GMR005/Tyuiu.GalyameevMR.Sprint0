using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.GalyameevMR.Sprint0.Task4.V0.Lib
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

        public static int Proizv(int a, int b)
        {
            return a * b;
        }

        public static double Chastn(int a, int b)
        {
            return a / b;
        }
    }
}

