using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01
{
	class Program
	{
		static void Main(string[] args)
		{
			MenuItem item = new MenuItem("Salo");
			item.Show();
			Console.WriteLine();

			item.Show(item.Text.Length + 1);
		}
	}
}
