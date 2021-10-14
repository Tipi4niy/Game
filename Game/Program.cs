using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
	class Program
	{	
		public static ConsoleKey GetButton()
        {
			var button = Console.ReadKey(true).Key;

			return button;
		}
		static void Main(string[] args)
		{
			Console.WriteLine("Добро пожаловать в World of dreams.");

			while (true)
            {
				Control.GetControl();

				Console.WriteLine("Нажмите клавишу Enter, чтобы начать.\n");


				ConsoleKey consoleKey = GetButton();

				if (consoleKey == ConsoleKey.Enter)
				{
					Console.Clear();

                    
					Console.Write("Введите имя персонажа: ");

					Player.player_name = Console.ReadLine();

					Introduction.Choose();
				}
				else if (consoleKey == ConsoleKey.Escape)
				{
					Environment.Exit(0);
				}
				else
				{
					Console.WriteLine("Вы нажали неверную клавишу!");
                    Console.WriteLine("\nНажмите любую клавишу...");
					Console.ReadKey(true);
					Console.Clear();

					continue;
				}
			}		
		}
	}
}
