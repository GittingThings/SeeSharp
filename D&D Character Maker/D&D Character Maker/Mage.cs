using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D_D_Character_Maker
{
    public class Mage : Character
    {
        public string Element { get; set; }

        public int Mana { get; set; }

        public Mage(string name, int health, int level, string race, string element, int mana) : base(name, health, level, race)
        {
            Element = element;
            Mana = mana;
        }

        public override string Display()
        {
            return Element;
        }


        public override string Attack()
        {
            return $"{Name} cast a {Element} spell with much success";
        }


    }
}
