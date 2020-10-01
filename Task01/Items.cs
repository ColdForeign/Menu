using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01
{
	class Exit : MenuItem
	{
		public override void Execute()
		{
			Console.WriteLine("Exit...");
			System.Environment.Exit( 0);
		}
	}
	class Help : MenuItem
	{
		public override void Execute()
		{
			Console.BackgroundColor = ConsoleColor.Cyan;
			Console.WriteLine("This program is for testing inheritance, " +
				"\nvirtual methods and abstract classes.");

			Console.BackgroundColor = ConsoleColor.DarkCyan;
			Console.WriteLine("MenuItem is an abstract class, " +
				"\nExecute () is its virtual method.");

			Console.BackgroundColor = ConsoleColor.Blue;
			Console.WriteLine("Exit, Help, Button inherit from MenuItem.");
			Console.WriteLine("All these elements inherit from the Menu class.");
			Console.ResetColor();
		}
	}

	class Button : MenuItem
	{
		public override void Execute()
		{
			Console.BackgroundColor = ConsoleColor.Cyan;
			Console.WriteLine("This is a button, it displays this text.");
			Console.ResetColor();

		}
	}

}
