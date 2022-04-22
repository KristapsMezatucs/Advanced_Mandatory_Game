using Advanced_Mandatory_Game.Creatures;
using Advanced_Mandatory_Game.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_Mandatory_Game.Potions
{
    public class HealthPotion : Potion, IPotion
    {
        private int _heal = 30;

        public int Heals { get { return _heal; } set { _heal = value; } }

        public int Heal(Player p)
        {
            if (p.Health != 100)
            {
                var newHealth = p.Health + Heals;
                return newHealth;
            }
            Console.WriteLine("You are at full health");
            return p.Health;           
        }
    }
}
