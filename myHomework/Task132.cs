using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Составить циклический алгоритм и программу для вычисления результата по формуле. 
// Для проверки программы задать X=0.5; n = 20.

namespace myHomework
{
    class Task132
    {
        double yfunc(double x, int k, double e)
        {
            double y = (pow(abs(x - k), 2) * sqrt(pow(e, k - 1))) / log(2 + pow(x, k) + pow(x, 2 * k + 1));
            return y;
        }

        int main()
        {
            double a, x, y, s, e;
            int n, k;

            std::cout << "\n Vvedite x: ";
            std::cin >> x;
            std::cout << "\n Vvedite n: ";
            std::cin >> n;

            e = exp(1.0);
            s = 0;
            a = pow(e, sqrt(x / n));

            for (k = 1; k <= n; k++)
            {
                y = yfunc(x, k, e);
                s += y;
                std::cout.precision(2);
                std::cout << std::fixed << y << " \t" << std::fixed << s << "\n";
            }

            std::cout.precision(2);
            std::cout << "\n" << std::fixed << s << " * " << a << " = " << std::fixed << s * a;

            return 0;
        }

    }
}
