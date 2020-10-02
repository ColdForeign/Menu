using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Task01
{
	class Menu
	{
		private MenuItem[] menuItems;
		private int currentItem;
		ConsoleColor selectColor;
		bool same;

		public ConsoleColor SelectColor
		{
			get => selectColor;
			set => selectColor = value;
		}

		public Menu()
		{
			same = true;
			currentItem = 0;
			SelectColor = ConsoleColor.Red;
			CreateStartArray();
			SetPositions();
		}

		public Menu(bool same)
		{
			this.same = same;
			currentItem = 0;
			SelectColor = ConsoleColor.Red;
			CreateStartArray();
			SetPositions();
		}

		public void StartMenu()
		{
			if (menuItems == null)
				return;
			ConsoleKeyInfo keyInfo;
			int prevIndex = 0;
			int maxLength = GetMaxLenght();

			do
			{
				menuItems[currentItem].ItemColor = selectColor;
				ShowItems(maxLength);
				Console.WriteLine("Use Up or Down Arrows to contol menu. \nIf you want to exit press 'Escape'.");
				keyInfo = Console.ReadKey(true);
				prevIndex = currentItem;

				switch (keyInfo.Key)
				{
					case ConsoleKey.UpArrow:
						Console.Clear();
						PrevMenuItem();
						break;
					case ConsoleKey.DownArrow:
						Console.Clear();
						NextMenuItem();
						break;
					case ConsoleKey.Enter:
						Console.Clear();
						menuItems[currentItem].Execute();
						break;
				}

				menuItems[prevIndex].SetStandartColors();
			} while (keyInfo.Key != ConsoleKey.Escape);
		}

		private void SetPositions()
		{
			if (menuItems == null)
				return;

			if (same)
			{
				int maxLenght = GetMaxLenght();
				int left = (Console.WindowWidth - maxLenght) / 2;
				for (int i = 0; i < menuItems.Length; i++)
					menuItems[i].Left = left;
			}
			else
				for (int i = 0; i < menuItems.Length; i++)
					menuItems[i].Left = (Console.WindowWidth - menuItems[i].Text.Length) / 2;

		}
		private void ShowItems(int left = 0)
		{

			for (int i = 0; i < menuItems.Length; i++)
			{
				if (same)
					menuItems[i].Show(left);
				else
					menuItems[i].Show();
				Console.WriteLine();
			}
		}

		private void CreateStartArray()
		{
			menuItems = new MenuItem[]
			{
				new Button("Some button"),
				new Help("Help"),
				new Exit("Exit")
			};
		}

		private void NextMenuItem()
		{
			if (currentItem == menuItems.Length - 1)
				currentItem = 0;
			else
				currentItem++;
		}

		private void PrevMenuItem()
		{
			if (currentItem == 0)
				currentItem = menuItems.Length - 1;
			else
				currentItem--;
		}

		private int GetMaxLenght()
		{
			int maxLenght = 0;
			int lenght;
			for (int i = 0; i < menuItems.Length; i++)
			{
				lenght = menuItems[i].Text.Length;
				if (lenght > maxLenght)
					maxLenght = lenght;
			}

			maxLenght += 4;
			return maxLenght;
		}
	}
}
