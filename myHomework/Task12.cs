using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Составить алгоритм и программу вычисления таблицы значений функции f(x) из задачи 1.1 для N значений аргумента X, равномерно распределенных на отрезке [A, B]. 
 * Для проверки программы задать N=10; A=0,55; B=1
 */

namespace myHomework
{
    class Task12
    {
		double ypoint(double x)
		{
			double y = abs(sin(sqrt(10.5 * x))) / (pow(x, 2.0 / 3) - 0.143) + 2 * x * 3.14;
			return y;
		}
		int main()
		{
			double A, B, h, y, x;
			int N;
			std::cout << "\n Vvedite nachalo otrezka A: ";
			std::cin >> A;
			std::cout << "\n Vvedite konec otrezka B: ";
			std::cin >> B;
			if (A >= B)
			{
				std::cout << "\n Vvedennie chisla ne udovletvoryaut usloviu A <= B \n";
			}
			else
			{
				std::cout << "\n Vvedite kolichestvo vichislenii N = ";
				std::cin >> N;
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
