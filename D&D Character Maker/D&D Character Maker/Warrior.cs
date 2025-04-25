using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D_D_Character_Maker
{
    public class Warrior : Character
    {
        public string WeaponType { get; set; }

        public int ArmorType { get; set;  }

        public Warrior(string name, int health, int level, string race, string weaponType, int armorType) : base(name, health, level, race)
        {
            WeaponType = weaponType;
            ArmorType = armorType;
        }

        public override string Display()
        {
            return WeaponType;
        }


        public override string Attack()
        {
            return $"{Name} uses a {WeaponType} with much success";
        }


    }
}
