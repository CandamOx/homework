using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myHomework
{
    class Task252
    {
		const int n = 3;

		int x_j(double a1, double a2, double a3)
		{
			int x;
			if (a1 < (a2 + a3) / 2.0)
			{
				x = 1;
			}
			else
			{
				x = 0;
			}
			return x;
		}

		int main()
		{
			double A[n][n];
			int i, j;
			std::vector<int> X(n);

			std::cout << "\n Vvedite elementi matrici: \n";
			for (i = 0; i < n; i++)
			{
				for (j = 0; j < n; j++)
					std::cin >> A[i][j];
			}

			std::cout << "\n Poluchena matrica: \n";
			for (i = 0; i < n; i++)
			{
				for (j = 0; j < n; j++)
					std::cout << A[i][j] << " ";
				std::cout << "\n";
			}

			std::cout << "\n Itogovii rezultat: \n";
			for (j = 0; j < n; j++)
			{
				for (i = 1; i < n - 1; i++)
					X[j] = x_j(A[i][j], A[i - 1][j], A[i + 1][j]);
				std::cout << X[j] << " ";
			}

			return 0;
		}

	}
}
