using Advanced_Mandatory_Game.Creatures;
using Advanced_Mandatory_Game.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_Mandatory_Game.Interfaces
{
    public interface ICreature
    {
        //Template Design Pattern
        public int Hit(Player p);
        public int ReceiveHit(Player p);
        //public WorldObject DropLoot();
        public bool IsDead();

    }
}
