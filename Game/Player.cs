using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class Player
    {
        public static string player_name;
        public string player_group;
        public int player_damage;
        public int player_defense;
        public static int player_hitPoints = 50;
        public string player_weapon_title;
        public int player_weapon_damage;

        public static Player GetPlayer()
        {
            Player player = new Player
            {          
                player_group = "Одиночка",
                player_damage = 5,
                player_defense = 5,
                player_weapon_title = Weapon.GetM416().title,
                player_weapon_damage = Weapon.GetM416().weapon_damage,
            };

            return player;           
        }
    }
}
