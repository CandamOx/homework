using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myHomework
{
    class Task433
    {
        const int N = 9;
        const int M = 4;

        class Matrix
        {
            private:
    int i, j, k, x, n, flag = 0;
            int a[N][M];

public:
    void input()
            {
                cout << "Введите матрицу:";
                for (i = 0; i < N; i++)
                {
                    for (j = 0; j < M; j++)
                        cin >> a[i][j];
                }
            }

            void output_source()
            {
                cout << "\nИсходная матрица:\n";
                for (i = 0; i < N; i++)
                {
                    for (j = 0; j < M; j++)
                        cout << a[i][j] << "\t";
                    cout << "\n";
                }
            }

            void sort()
            {
                for (j = 0; j < M; j++)
                    for (i = 0; i < N; i++)
                        if (a[i][j] < 0)
                            for (k = N - 1; k > i; k--)
                                if (a[k][j] >= 0)
                                {
                                    x = a[i][j];
                                    a[i][j] = a[k][j];
                                    a[k][j] = x;
                                }
            }

            void output_sort()
            {
                cout << "\nОтсортированная матрица:\n";
                for (i = 0; i < N; i++)
                {
                    for (j = 0; j < M; j++)
                        cout << a[i][j] << "\t";
                    cout << "\n";
                }
            }

            void output_final()
            {
                for (i = 0; i < N; i++)
                {
                    for (j = 0; j < M; j++)
                    {
                        if (a[i][j] < 0)
                            flag = 1;
                    }
                    if (flag == 1) break;
                }

                n = i;
                cout << "\nМатрица без строк с отрицательными элементами:\n";
                for (i = 0; i < n; i++)
                {
                    for (j = 0; j < M; j++)
                        cout << a[i][j] << "\t";
                    cout << "\n";
                }
            }
        };

        int main()
        {
            setlocale(LC_ALL, "Russian");

            Matrix test;

            test.input();
            test.output_source();
            test.sort();
            test.output_sort();
            test.output_final();
            return 0;
        }

    }
}
