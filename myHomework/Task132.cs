﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static System.Math;
// Составить циклический алгоритм и программу для вычисления результата по формуле. 
// Для проверки программы задать X=0.5; n = 20.

namespace myHomework
{
    public class Task132
    {
        private double Yfunc(double x, int k, double e)
        {
            return 
                (   Math.Pow
                (   Math.Abs(x - k), 2)
                *   Math.Sqrt
                (   Math.Pow(e, k - 1)))
                /   Math.Log(2 
                +   Math.Pow(x, k)
                +   Math.Pow(x, 2 * k + 1));
        }

        public int Main()
        {
            try
            {
                Console.WriteLine("\n Введите x: ");
                double x = Console.Read();
                Console.WriteLine("\n Введите n: ");
                int n = Console.Read();

                double e = Math.Exp(1.0);
                double s = 0;
                double a = Math.Pow(e, Math.Sqrt(x / n));

                for (int k = 1; k <= n; k++)
                {
                    double y = Yfunc(x, k, e);
                    s += y;
                    Console.WriteLine("\n", y, " \t", s);
                }

                Console.WriteLine("\n", s, " * ", a, " = ", s * a);

                return 0;
            } 
            catch(System.IO.IOException e)
            {
                Console.WriteLine("\n Введены неверные параметры, операция прервана");
                if (e.Source != null)
                    Console.WriteLine("IOException source: {0}", e.Source);
                throw;
            }
        }

    }
}
