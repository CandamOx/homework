using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myHomework
{
    class Task142
    {
		int main()
		{
			int A, n, i, k = 0, sum = 0;

			std::cout << "Vvedite chislo A: \n";
			std::cin >> A;

			std::cout << "\n Vvedite kolichestvo elementov massiva N: \n";
			std::cin >> n;

			std::vector<int> X(n);
			std::vector<int> Y(n);
			std::vector<int> Z(n);

			std::cout << "\n Napolnite massivi chislami \n";
			for (i = 0; i < n; i++)
			{
				std::cout << "Vvedite element massiva X: ";
				std::cin >> X[i];
				std::cout << "\n Vvedite element massiva Y: ";
				std::cin >> Y[i];

				Z[i] = X[i] * Y[i];
				if (Z[i] <= A)
				{
					sum += Z[i];
					k++;
				}
				std::cout << X[i] << " * " << Y[i] << " = " << Z[i] << "\n";
			}

			std::cout << "\n Kolichestvo par = " << k << "\n Summa proizvedenii = " << sum;
		}
	}
}
