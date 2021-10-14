using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class Control
    {
        public static void GetControl()
        {       
            Console.WriteLine("\nДля продвижения - используйте любую кнопку, кроме кнопок Alt, Shift, Ctrl и кнопок выделенных для любых других действий!");
            Console.WriteLine("Посмотреть управление - нажмите 'Tab'.\n");
            Console.WriteLine("Информация о персонаже - нажмите 'I'.\n");
            Console.WriteLine("Атаковать(во время боя) - нажмите 'Space'.\n");
            Console.WriteLine("Выйти - нажмите 'Esc'.\n");
        }
    }
}
