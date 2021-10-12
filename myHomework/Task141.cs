using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myHomework
{
    class Task141
    {
		double compE(double E, double a)
		{
			E = E * a;
			return E;
		}

		int main()
		{
			double E = 1.0;
			int n;
			std::cout << "Vvedite razmer massiva n: \n";
			std::cin >> n;
			std::vector<double> a(n +1);

			std::cout << "\n Vvedite vse elementi massiva: ";
			for (int i = 1; i <= n; i++)
			{
				std::cin >> a[i];
				if (i == 1 || i % 3 == 0)
					E = compE(E, a[i]);
			}

			std::cout.precision(2);
			std::cout << "Proizvedenie: " << std::fixed << E;
			return 0;
		}

	}
}
