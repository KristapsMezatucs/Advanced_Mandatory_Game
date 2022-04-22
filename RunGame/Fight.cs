using Advanced_Mandatory_Game.Creatures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RunGame
{
    public class Fight
    {
        public static void BeginFight(Creature c, Player p)
        {
            while(c.IsDead() != true && p.IsDead() != true)
            {
                p.Hit(c);
                Console.WriteLine($"U hit Creature, it has {c.Health} hp left");
                if (c.IsDead() != true)
                {
                    c.Hit(p);
                    Console.WriteLine($"Creature hit u, u have {p.Health} hp left");
                }
                else
                    break;
            }
        }
    }
}
