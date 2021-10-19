using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myHomework
{
    public class Task251
    {
		const int n = 6;
		const int m = 3;

		int t_count(int t, double a)
		{
			if (a == 0)
			{
				t++;
			}
			return t;
		}

		public int Main()
		{
			double A[n][m];
			int i, j, k = 0, t;
			std::cout << "Vvedite elementi matrici A: \n";
			for (i = 0; i < n; i++)
			{
				for (j = 0; j < m; j++)
				{
					std::cin >> A[i][j];
				}
			}

			std::cout << "\n Matrica: \n";
			for (i = 0; i < n; i++)
			{
				for (j = 0; j < m; j++)
				{
					std::cout << A[i][j] << " ";
				}
				std::cout << "\n";
			}

			std::cout << "\n Nomera strok, imeushih ne menee 2 nulevih elementov: \n";
			for (i = 0; i < n; i++)
			{
				t = 0;
				for (j = 0; j < m; j++)
				{
					t = t_count(t, A[i][j]);
				}
				if (t >= 2)
				{
					std::cout << i + 1 << " ";
					k++;
				}
			}

			if (k == 0)
			{
				std::cout << "\n Podhodyashih strok net \n";
			}
			else
			{
				std::cout << "\n Kolichestvo podhodyashih strok: " << k;
			}

			return 0;
		}

	}
}
