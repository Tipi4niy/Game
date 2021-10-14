using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class Check
    {
        public static void GetCheck()
        {
            ConsoleKey consoleKey = Program.GetButton();

            if (consoleKey == ConsoleKey.I)
            {
                Information.GetInformationPlayer();
                GetCheck();
            }
            else if (consoleKey == ConsoleKey.Tab)
            {
                Control.GetControl();
                GetCheck();
            }
            else if (consoleKey == ConsoleKey.Escape)
            {
                Exit.GetExit();
                GetCheck();
            }           

            else return;
        }
    }
}
