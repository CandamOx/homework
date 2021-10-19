using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myHomework
{
    public class Task142
    {
		public int Main()
		{
			try
			{
				int k = 0, sum = 0;

				Console.WriteLine("Введите число A: \n");
				int A = Console.Read();

				Console.WriteLine("\n Введите количество элементов массива N: \n");
				int n = Console.Read();

				int[] X = new int[n];
				int[] Y = new int[n];
				int[] Z = new int[n];

				Console.WriteLine("\n Наполните массив числами \n");
				for (int i = 0; i < n; i++)
				{
					Console.WriteLine("Введите элемент массива X: ");
					X[i] = Console.Read();
					Console.WriteLine("\n Введите элемент массива Y: ");
					Y[i] = Console.Read();

					Z[i] = X[i] * Y[i];
					if (Z[i] <= A)
					{
						sum += Z[i];
						k++;
					}
					Console.WriteLine("\n", X[i], " * ", Y[i], " = ", Z[i]);
				}

				Console.WriteLine("\n Количество пар = ", k, "\n Сумма произведений = ", sum);

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
