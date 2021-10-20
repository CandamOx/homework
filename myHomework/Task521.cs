using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myHomework
{
    class Task521
    {
        using namespace std;

class Student
	{
		private:
	string group, name;
		int age, sex, physics, math, inf, grant;

		public:
	void input()
		{
			cout << "Введите код группы: ";
			cin >> group;
			cout << "Введите ФИО: ";
			cin >> name;
			cout << "Введите год рождения: ";
			cin >> age;
			cout << "Выберите пол (подсказка: 1 - Мужской \t 2 - Женский): ";
			cin >> sex;
			cout << "Оценка по физике: ";
			cin >> physics;
			cout << "Оценка по математике: ";
			cin >> math;
			cout << "Оценка по информатике: ";
			cin >> inf;
			cout << "Введите наличие стипендии (подсказка: 0 - нет стипендии \t 1 - есть стипендия): ";
			cin >> grant;
		}

		void output()
		{
			cout << "ФИО:" << name << endl;
		}

		bool check()
		{
			if (grant == 0 && physics >= 3 && math >= 3 && inf >= 3) return true;
			else return false;
		}
	};

	int main()
	{
		try
		{
			const int kolichestvo_student = 5;
			Student Info[kolichestvo_student];

			for (int i = 0; i < kolichestvo_student; i++)
			{
				Info[i].input();
			}

			for (int i = 0; i < kolichestvo_student; i++)
			{
				if (Info[i].check())
				{
					Info[i].output();
				}
			}

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
