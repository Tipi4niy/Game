using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class RoadToHome
    {
        public static void Run()
        {
            Console.WriteLine("Вы побежали в сторону дома.\n");
            Check.GetCheck();

            Console.WriteLine("Выстрелы.\n");
            Check.GetCheck();

            Console.WriteLine("Фух...Вы спрятались за деревом.\n");
            Check.GetCheck();

            Console.WriteLine("Вам чуть не прострелили колено.\n");
            Check.GetCheck();

            Console.WriteLine("Вы решили оглянуться.\n");
            Check.GetCheck();

            Console.WriteLine("Военный стреляет по вам.\n");
            Check.GetCheck();

            Console.WriteLine("Нужно что-то делать.\n");
            Check.GetCheck();

            Console.WriteLine("Он двигается в вашу сторону.\n");
            Check.GetCheck();

            Console.WriteLine("Вы достаёте винтовку, но она не перезаряжена.\n");

            while (true)
            {
                try
                {
                    Console.WriteLine("Перезарядить винтовку - нажмите 'R'.\n");
                    Console.WriteLine("Напасть с кулаками - нажмите 'W'.\n");
                    Check.GetCheck();

                    if (Program.GetButton() == ConsoleKey.R)
                    {
                        Fight.GetFightMercenary();
                    }
                    else if (Program.GetButton() == ConsoleKey.W)
                    {
                        ///Рукопашка
                    }
                    else
                    {
                        Console.WriteLine("Вы нажали неверную клавишу!");
                        Console.WriteLine("\nНажмите любую клавишу...\n");
                        Console.ReadKey(true);

                        continue;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Вы нажали неверную клавишу!");
                    Console.WriteLine("\nНажмите любую клавишу...\n");
                    Console.ReadKey(true);

                    continue;
                }
            }  
        }
        public static void Creep()
        {
            Console.WriteLine("Вы аккуратно передвигаетесь в сторону дома.\n");
            Check.GetCheck();

            Console.WriteLine("Шорох за углом.\n");
            Check.GetCheck();

            Console.WriteLine("Вы аккуратно выглядываете и видите военного.\n");
            Check.GetCheck();

            Console.WriteLine("Он вооружён.\n");
            Check.GetCheck();

            Console.WriteLine("Кто он? Что он здесь делает?\n");
            Check.GetCheck();
        }
    }
}
