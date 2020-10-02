using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01
{
	class Exit : MenuItem
	{
		public Exit() : base()
		{

		}

		public Exit(string text) : base(text)
		{

		}

		public Exit(string text, ConsoleColor itemColor, ConsoleColor textColor)
			: base(text, itemColor, textColor)
		{

		}
		public override void Execute()
		{
			Console.Clear();
			Console.ForegroundColor = ConsoleColor.Magenta;
			Console.WriteLine("Exit...");
			System.Environment.Exit(0);
		}
	}
	class Help : MenuItem
	{
		public Help() : base()
		{

		}

		public Help(string text) : base(text)
		{

		}

		public Help(string text, ConsoleColor itemColor, ConsoleColor textColor)
			: base(text, itemColor, textColor)
		{

		}

		public override void Execute()
		{
			Console.ForegroundColor = ConsoleColor.Cyan;
			Console.WriteLine("This program is for testing inheritance, " +
				"\nvirtual methods and abstract classes.\n");

			Console.ForegroundColor = ConsoleColor.DarkCyan;
			Console.WriteLine("MenuItem is an abstract class, " +
				"\nExecute () is its virtual method.\n");

			Console.ForegroundColor = ConsoleColor.Blue;
			Console.WriteLine("Exit, Help, Button inherit from MenuItem.");
			Console.WriteLine("All these elements inherit from the Menu class.\n");
			Console.ResetColor();
		}
	}

	class Button : MenuItem
	{
		public Button() : base()
		{

		}

		public Button(string text) : base(text)
		{

		}

		public Button(string text, ConsoleColor itemColor, ConsoleColor textColor)
			: base(text, itemColor, textColor)
		{

		}

		public override void Execute()
		{
			Console.ForegroundColor = ConsoleColor.Cyan;
			Console.WriteLine("This is a button, it displays this text.");
			Console.ResetColor();

		}
	}

}
