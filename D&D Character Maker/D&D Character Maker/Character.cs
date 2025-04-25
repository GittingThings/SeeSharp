using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D_D_Character_Maker
{
    public class Character
    {


        //Characters Name
        public string Name { get; set; }
        
        //Character Health
        public int Health { get; set; }

        //Character Level
        public int Level { get; set; }

        //Character Race
        public string Race { get; set; }

        public Character(string name, int health, int level, string race)
        {
            Name = name;
            Health = health;
            Level = level;
            Race = race;
        }

        public virtual string Display()
        {
            return Name;
        }


        public virtual string Attack()
        {
            return Name + "attacks!";
        }
    }
}
