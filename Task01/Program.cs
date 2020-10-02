using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Task01
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.SetWindowPosition(0, 0);

			Console.SetWindowSize(Console.LargestWindowWidth, Console.LargestWindowHeight);
			Menu menu = new Menu(false);

			menu.StartMenu();
		}
	}
}
