using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class Introduction
    {
        public static void Choose()
        {
            Console.WriteLine("\nПосле тяжёлого приземления вы очнулись в лесу...\n");
            Console.WriteLine("Вы встали и подняли свою M416.\n");
            Check.GetCheck();

            Console.WriteLine("Вокруг было темно.\n");
            Check.GetCheck();

            Console.WriteLine("Неподалёку вы увидели дом, по виду он был заброшен.\n");
            Check.GetCheck();

            Console.WriteLine("Вы решили обыскать его.\n");
            Check.GetCheck();

            Console.WriteLine("Быстро направиться в сторону дома или прокрасться тайком?\n");

            while (true)
            {
                 try
                 {
                     Console.WriteLine("Быстро направиться в сторону дома - нажмите 'W'.\n");
                     Console.WriteLine("Прокрасться тайком - нажмите 'S'.\n");
                     Check.GetCheck();

                     if (Program.GetButton() == ConsoleKey.W)
                     {
                         RoadToHome.Run();
                     }
                     else if (Program.GetButton() == ConsoleKey.S)
                     {
                         RoadToHome.Creep();
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
    }
}
