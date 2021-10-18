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
    class Task12
    {
		double ypoint(double x)
		{
			double y = Math.Abs(Math.Sign(Math.Sqrt(10.5 * x))) / (Math.Pow(x, 2.0 / 3) - 0.143) + 2 * x * 3.14;
			return y;
		}
		int main()
		{
			double A, B, h, y, x;
			int N;

			try 
			{
				Console.WriteLine("\nВвести точку начала отрезка");
				A = Console.Read();
				Console.WriteLine("\nВвести точку конца отрезка");
				B = Console.Read();
			}
			catch (System.IO.IOException e)
            {
				Console.WriteLine("\nВведены некорректные данные", e);
				Exception.StackTrace(e);
            }

			if (A >= B)
			{
				Console.WriteLine("\n Vvedennie chisla ne udovletvoryaut usloviu A <= B \n");
			}
			else
			{
				Console.WriteLine("\n Vvedite kolichestvo vichislenii N = ");
				try
				{
					N = Console.Read();
				} catch (System.IO.IOException e) 
				{
					Console.WriteLine("\nВведены некорректные данные", e);
				}
					h = (B - A) / (N - 1);
				x = A;

				for (int i = 0; i < N; i++)
				{
					double y = ypoint(x);
					std::cout.precision(2);
					std::cout << "x = " << std::fixed << x << " \t" << "y = " << std::fixed << y << std::endl;
					x += h;
				}
			}

			return 0;
		}

	}
}
