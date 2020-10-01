using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01
{
	class MenuItem
	{
		private string text;
		private ConsoleColor itemColor;
		private ConsoleColor textColor;

		public MenuItem()
		{
			text = default;
			SetStandartColors();
		}
		public MenuItem(string text)
		{
			Text = text;
			SetStandartColors();
		}

		public MenuItem(string text, ConsoleColor itemColor, ConsoleColor textColor)
		{
			Text = text;
			ItemColor = itemColor;
			TextColor = textColor;
		}
		public string Text
		{ 
			get => text;
			set => text = String.IsNullOrEmpty(value) ? default : value;
		}
		public ConsoleColor ItemColor { get => itemColor; set => itemColor = value; }
		public ConsoleColor TextColor { get => textColor; set => textColor = value; }

		public virtual void Execute()
		{
			Console.WriteLine("This Menu Item does nothing");
		}

		public virtual void Show()
		{
			if (!CheckText())
				return;

			Console.ForegroundColor = itemColor;
			for (int i = 0; i < 3; i++)
			{
				if (i == 1)
				{
					Console.Write("* ");
					Console.ForegroundColor = textColor;
					Console.Write(text);
					Console.ForegroundColor = itemColor;
					Console.Write(" *\n");
					continue;
				}
				for (int j = 0; j < text.Length + 4; j++)
					Console.Write('*');
				Console.WriteLine();
			}
			Console.ResetColor();

		}

		public virtual void Show(int lenght)
		{
			if (lenght < 1)
				return;

			if (CheckText())
			{
				if (lenght <= text.Length + 1)
				{
					ShowError();
					return;
				}
			}
			else
				return;

			if (lenght - 4 == text.Length)
			{
				Show();
				return;
			}
			int spacesSize = lenght - (2 + text.Length);

			int leftSpaces = spacesSize / 2;
			if (spacesSize % 2 != 0)
				 leftSpaces = (int)Math.Round((float)spacesSize / 2f);

			Console.ForegroundColor = itemColor;
			for (int i = 0; i < 3; i++)
			{
				if (i == 1)
				{
					
					Console.Write('*' + new String(' ', (leftSpaces)));
					Console.ForegroundColor = textColor;
					Console.Write(text);
					Console.ForegroundColor = itemColor;
					Console.Write(new String(' ', (spacesSize - leftSpaces)) + "*\n");
					continue;
				}
				for (int j = 0; j < lenght; j++)
					Console.Write('*');
				Console.WriteLine();
			}
			Console.ResetColor();

		}
		public override string ToString()
		{
			if ((text == default) || (String.IsNullOrEmpty(text)))
				return "Menu item misconfigured. Output error!";
			
			StringBuilder builder = new StringBuilder();

			for (int i = 0; i < 3; i++)
			{
				if (i == 1)
				{
					builder.Append("* " + text + " *\n");
					continue;
				}
				for (int j = 0; j < text.Length + 4; j++)
					builder.Append("*");
				builder.Append("\n");

			}
			return builder.ToString();
		}

		public void SetStandartColors()
		{
			itemColor = ConsoleColor.Cyan;
			textColor = ConsoleColor.White;
		}

		private void ShowError()
		{
			Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine("Menu item misconfigured. Output error!");
			Console.ResetColor();
		}

		private bool CheckText()
		{
			if (text == default)
			{
				ShowError();
				return false;
			}
			return true;

		}

	}


}
