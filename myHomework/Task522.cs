using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myHomework
{
    public class Task522
    {

		public class Him
		{
			public Char[] nazv = new Char[50];
			public int ves;
			public Char[] prov = new Char[30];
			public float k;

		public bool Polu()
		{
			if (strcmp(prov, "полупроводник") == 0)
				if (k > 5)
					return true;
			return false;
		}
	};

	class table
	{
		public:
		him* t;
		int n;

		table(char name[])
		{
			n = 0;
			char temp[255];
			fstream f, f2;
			f.open(name);

			if (f)
			{
				while (!f.eof())
				{
					f.getline(temp, 255);
					if (strcmp(temp, "") != 0)
						n++;
				}
				f.close();
			}

			t = new him[n];
			n = 0;

			f2.open(name);
			if (f2)
			{
				while (!f2.eof())
				{
					f2 >> t[n].nazv;
					f2 >> t[n].ves;
					f2 >> t[n].prov;
					f2 >> t[n].k;
					n++;
				}
				f2.close();
			}
		}

		void print()
		{
			cout << "Все данные из файла " << endl;
			for (int i = 0; i < n; i++)
				cout << t[i].nazv << "\t  Уд. вес: " << t[i].ves << "\t" << t[i].prov << "\t Кол-во: " << t[i].k << "\n";
		};

		void find()
		{
			cout << "Полупроводники, которых более 5:" << endl;
			for (int i = 0; i < n; i++)
				if (t[i].polu())
					cout << t[i].nazv << "\t Уд. вес: " << t[i].ves << "\n";
		};

	};

	public int Main()
	{
			try
			{
				table tab("input.txt");
				tab.print();
				tab.find();
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
