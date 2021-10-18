using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

using static System.Math;

/*
 * Составить алгоритм и программу вычисления таблицы значений функции f(x) из задачи 1.1 для N значений аргумента X, равномерно распределенных на отрезке [A, B]. 
 * Для проверки программы задать \N=10; A=0,55; B=1
 */

namespace myHomework
{
    public class Task12
    {
        private double Ypoint(double x)
		{
			double y = Math.Abs(
				Math.Sign(
					Math.Sqrt(10.5 * x))) 
				/ (Math.Pow(x, 2.0 / 3) - 0.143) 
				+ 2 * x * 3.14;
			return y;
		}
		public int Main()
		{
			try 
			{
				Console.WriteLine("\nВвести точку начала отрезка");
				double A = Console.Read();
				Console.WriteLine("\nВвести точку конца отрезка");
				double B = Console.Read();
				if (A >= B)
				{
					Console.WriteLine("\n Введённые числа не удовлетворяют условию. A <= B \n");
				}
				else
				{
					Console.WriteLine("\n Введите количество вычислений N = ");
					int N = Console.Read();					
					double h = (B - A) / (N - 1);
					double x = A;

					for (int i = 0; i < N; i++)
					{
						double y = Ypoint(x);
						Console.WriteLine("x = ", x, " \t y = ", y);
						x += h;
					}
				}

				return 0;
			}
			catch (System.IO.IOException e)
			{
				Console.WriteLine("\n Введены неверные параметры, операция прервана");
				if (e.Source != null)
					Console.WriteLine("IOException source: {0}", e.Source);
				throw;
			}
		}

	}
}
