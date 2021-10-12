using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myHomework
{
    class Task143
    {
		double minn(double ai, double ani)
		{
			double min = abs(ai) - abs(ani);
			return min;
		}

		int main()
		{
			double min;
			int n, i;
			std::cout << "Vvedite razmernost massiva A (chetnoe chislo): ";
			std::cin >> n;

			if (n % 2 != 0 || n <= 0)
				std::cout << "\n Nepravilnii razmer massiva";
			else
			{
				std::vector<double> A(n);
				cout << "\n Vvedite elementi massiva A: \n";
				for (i = 0; i < n; i++)
				{
					std::cin >> A[i];
				}

				min = abs(A[0]) - abs(A[n - 1]);
				for (i = 1; i <= n / 2; i++)
				{
					if (abs(A[i]) - abs(A[n - i]) < min)
						min = minn(A[i], A[n - i]);
				}
				std::cout << "\n Naimenshaya raznost: " << min;
			}

			return 0;
		}

	}
}
