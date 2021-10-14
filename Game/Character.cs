using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class Character
    {
        public string name;
        public string group;
        public double damage;
        public double defense;
        public double hitPoints;
        public string weapon_title;
        public int weapon_damage;

        readonly static Random random = new Random();

        public Character GetMercenary()
        {
            Character mercenary = new Character
            {
                name = "Наёмник",
                group = "Наёмники",
                damage = random.Next(11),
                defense = random.Next(6),
                hitPoints = random.Next(51),
                weapon_title = Weapon.GetWeapon().title,
                weapon_damage = Weapon.GetWeapon().weapon_damage,
            };

            return mercenary;
        }

        public Character GetMilitary()
        {
            Character military = new Character
            {              
                name = "Военный",
                group = "Военные",
                damage = random.Next(6),
                defense = random.Next(11),
                hitPoints = random.Next(51),
                weapon_title = Weapon.GetWeapon().title,
                weapon_damage = Weapon.GetWeapon().weapon_damage,
            };

            return military;
        }

        public Character GetBandit()
        {
            Character bandit = new Character
            {        
                name = "Бандит",
                group = "Бандиты",
                damage = random.Next(6),
                defense = random.Next(6),
                hitPoints = random.Next(101),
                weapon_title = Weapon.GetWeapon().title,
                weapon_damage = Weapon.GetWeapon().weapon_damage,
            };

            return bandit;
        }
    }
}
