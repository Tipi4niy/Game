using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class Information
    {
        public static void GetInformationPlayer()
        {
            Player player = Player.GetPlayer();

            Console.WriteLine("\nИнформация о персонаже:\n");
            Console.WriteLine($"Имя: {Player.player_name}.");
            Console.WriteLine($"Группировка: {player.player_group}.");
            Console.WriteLine($"Урон: {player.player_damage}.");
            Console.WriteLine($"Защита: {player.player_defense}.");
            Console.WriteLine($"ХП: {Player.player_hitPoints}.\n");
            Console.WriteLine($"Оружие: {player.player_weapon_title}.");
            Console.WriteLine($"Урон оружием: {player.player_weapon_damage}.\n");
        }
        public static void GetInformationMercenary(Character mercenary)
        {
            Console.WriteLine("\nИнформация о военном:\n");
            Console.WriteLine($"Имя: {mercenary.name}.");
            Console.WriteLine($"Группировка: {mercenary.group}.");
            Console.WriteLine($"Урон: {mercenary.damage}.");
            Console.WriteLine($"Защита: {mercenary.defense}.");
            Console.WriteLine($"ХП: {mercenary.hitPoints}.\n");
            Console.WriteLine($"Оружие: {mercenary.weapon_title}.");
            Console.WriteLine($"Урон оружием: {mercenary.weapon_damage}.\n");
        }
        public static void GetInformationMilitary(Character military)
        {
            Console.WriteLine("\nИнформация о военном:\n");
            Console.WriteLine($"Имя: {military.name}.");
            Console.WriteLine($"Группировка: {military.group}.");
            Console.WriteLine($"Урон: {military.damage}.");
            Console.WriteLine($"Защита: {military.defense}.");
            Console.WriteLine($"ХП: {military.hitPoints}.\n");
            Console.WriteLine($"Оружие: {military.weapon_title}.");
            Console.WriteLine($"Урон оружием: {military.weapon_damage}.\n");
        }
        public static void GetInformationBandit(Character bandit)
        {
            Console.WriteLine("\nИнформация о военном:\n");
            Console.WriteLine($"Имя: {bandit.name}.");
            Console.WriteLine($"Группировка: {bandit.group}.");
            Console.WriteLine($"Урон: {bandit.damage}.");
            Console.WriteLine($"Защита: {bandit.defense}.");
            Console.WriteLine($"ХП: {bandit.hitPoints}.\n");
            Console.WriteLine($"Оружие: {bandit.weapon_title}.");
            Console.WriteLine($"Урон оружием: {bandit.weapon_damage}.\n");
        }  
    }
}
