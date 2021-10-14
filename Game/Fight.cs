using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class Fight
    {
        public static void GetFightMercenary()
        {
           while (true)
           {
                Character mercenary = new Character();

                mercenary = mercenary.GetMercenary();
                while (true)
                {
                    Information.GetInformationPlayer();

                    Character _mercenary = mercenary;

                    Information.GetInformationMercenary(_mercenary);

                    Player player = Player.GetPlayer();

                    ConsoleKey consoleKey = Program.GetButton();

                    if (consoleKey == ConsoleKey.Spacebar)
                    {
                        Player.player_hitPoints = Player.player_hitPoints - _mercenary.weapon_damage + player.player_defense;
                        _mercenary.hitPoints = _mercenary.hitPoints - player.player_weapon_damage + _mercenary.defense;

                        if(Player.player_hitPoints <= 0 && _mercenary.hitPoints <=0)
                        {
                            Console.WriteLine("Вы перезарядили винтовку.\n");
                            Check.GetCheck();

                            Console.WriteLine("Выстрел...Мимо.\n");
                            Check.GetCheck();

                            Console.WriteLine("Ещё один.\n");
                            Check.GetCheck();

                            Console.WriteLine("Несколько патронов попадают в противника и его тело бездыханно рушится на землю.\n");
                            Check.GetCheck();

                            Console.WriteLine("Но противник успевает выстрелить в ответ.\n");
                            Check.GetCheck();

                            Console.WriteLine("Похоже сегодня не ваш день...Пуля пролетает сквозь кору дерева и попадает вам прямо в голову...Увы, но вы умерли.\n");
                            Check.GetCheck();

                            Console.WriteLine("\nОчень жаль, но стоит попробовать ещё раз!\n");
                            Check.GetCheck();

                            Introduction.Choose();
                        }
                        else if(Player.player_hitPoints <= 0)
                        {
                            Console.WriteLine("Вы слишком поспешили...\n");
                            Check.GetCheck();

                            Console.WriteLine("Винтовка выпадает у вас из рук.\n");
                            Check.GetCheck();

                            Console.WriteLine("Вы собираетесь её поднять, но увы уже поздно.\n");
                            Check.GetCheck();

                            Console.WriteLine("Меткий выстрел пронизывает вашу грудную клетку и вы отправляетесь в мир иной.\n");
                            Check.GetCheck();

                            Console.WriteLine("\nПопробуйте ещё раз, уверен вам повезёт!\n");
                            Check.GetCheck();

                            Introduction.Choose();
                        }
                        else if (_mercenary.hitPoints <= 0)
                        {
                            Console.WriteLine("Вы перезарядили винтовку и открыли огонь по противнику.\n");
                            Check.GetCheck();

                            Console.WriteLine("Выстрел...Мимо.\n");
                            Check.GetCheck();

                            Console.WriteLine("Ещё один.\n");
                            Check.GetCheck();

                            Console.WriteLine("Патрон пролетает мимо противника.\n");
                            Check.GetCheck();

                            Console.WriteLine("Несколько минут перестрелки, ни к чему не приводят.\n");
                            Check.GetCheck();

                            Console.WriteLine("Противник решает сблизить дистанцию, но цепляясь за забор...Падает.\n");
                            Check.GetCheck();

                            Console.WriteLine("Иии...Вы наносите решающий выстрел в голову.\n");
                            Check.GetCheck();

                            Console.WriteLine("Нельзя быть настолько неосторожным в такой момент.\n");
                            Check.GetCheck();
                        }

                        continue;
                    }
                    else
                    {
                        Console.WriteLine("Вы нажали неверную клавишу!");
                        Console.WriteLine("\nНажмите любую клавишу...");
                        Console.ReadKey(true);

                        continue;
                    }
                }   
            }            
        }
    }
}
