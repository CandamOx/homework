using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myHomework
{
    public class Task141
    {
		double CompE(double E, double a)
		{
			E = E * a;
			return E;
		}

		public int Main()
		{
			try {
				double E = 1.0;

				Console.WriteLine("Введите размер массива n: \n");
				int n = Console.Read();
				std::vector<double> a(n +1);

				Console.WriteLine("\n Введите все элементы массива: ");
				for (int i = 1; i <= n; i++)
				{
					a[i] = Console.Read();
					i == 1 || i % 3 == 0 ? E = CompE(E, a[i]) : ;
				

				std::cout.precision(2);
				std::cout << "Proizvedenie: " << std::fixed << E;

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
