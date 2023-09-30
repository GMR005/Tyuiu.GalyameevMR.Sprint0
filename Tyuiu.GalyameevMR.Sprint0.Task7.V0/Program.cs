﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.GalyameevMR.Sprint0.Task7.V0.Lib;
namespace Tyuiu.GalyameevMR.Sprint0.Task7.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт 7. Выполнил: Галямеев М.Р. | ПКТб-23-1";
            Console.WriteLine("****************************************************************");
            Console.WriteLine("* Спринт #0                                                     ");
            Console.WriteLine("* Тема: Создание итогового решения по спринту                   ");
            Console.WriteLine("* Задание #7                                                    ");
            Console.WriteLine("* Вариант #0 7                                                  ");
            Console.WriteLine("* Выполнил: Галямеев М.Р. | ПКТб-23-1                           ");
            Console.WriteLine("****************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                      ");
            Console.WriteLine("* Написать программу, которая суммирует значения двух");
            Console.WriteLine("двух одинаковых по длине массивов");
            Console.WriteLine("*                                                               ");
            Console.WriteLine("****************************************************************");
            Console.WriteLine("****************************************************************");
            Console.WriteLine("*ИСХОДНЫЕ ДАННЫЕ:                                              *");
            Console.WriteLine("****************************************************************");


            int[] arrayNums1 = new int[] { 1, 2, 3, 4, 5 };
            Console.WriteLine("Значения элементов первого массива");
            for (int i = 0; i < arrayNums1.Length; i++)
            {
                Console.Write(arrayNums1[i] + " , ");
            }
            Console.WriteLine();

            int[] arrayNums2 = new int[] { 1, 2, 3, 4, 5 };
            Console.WriteLine("Значения элементов второго массива");
            for (int i = 0; i < arrayNums2.Length; i++)
            {
                Console.Write(arrayNums2[i] + " , ");
            }

            Console.WriteLine();
            Console.WriteLine("****************************************************************");
            Console.WriteLine("*РЕЗУЛЬТАТ:                                                     ");
            Console.WriteLine("****************************************************************");

            if (arrayNums1.Length == arrayNums2.Length)
            {
                int[] resultArray = DataService.AdditionArrays(arrayNums1, arrayNums2);
                Console.WriteLine("Сумма элементов равна: ");
                for (int i = 0; i < resultArray.Length; i++)
                {
                    Console.Write(resultArray[i] + " , ");
                }

            }

            else
            {
                Console.WriteLine("Ошибка! Исходные массивы имеют разное значение");
            }
            Console.ReadKey();
        }
    }
}
