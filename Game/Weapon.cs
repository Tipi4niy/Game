using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class Weapon
    {
        public string title;
        public int weapon_damage;

        public static Weapon GetAk47()
        {
            Weapon ak47 = new Weapon
            {
                title = "AK-47",
                weapon_damage = 12
            };

            return ak47;
        }

        public static Weapon GetM416()
        {
            Weapon m416 = new Weapon
            {
                title = "M416",
                weapon_damage = 10
            };

            return m416;
        }

        public static Weapon GetP18c()
        {
            Weapon p18c = new Weapon
            {
                title = "P18C",
                weapon_damage = 6
            };

            return p18c;
        }

        public static Weapon GetWeapon()
        {
            Random random = new Random();

            Weapon weapon = new Weapon();

            int i = random.Next(3);

            if (i == 0) weapon = GetAk47();
            else if (i == 1) weapon = GetM416();
            else if (i == 2) weapon = GetP18c();

            return weapon;
        }
    }
}
