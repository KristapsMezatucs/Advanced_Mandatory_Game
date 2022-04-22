using Advanced_Mandatory_Game.Interfaces;
using Advanced_Mandatory_Game.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_Mandatory_Game
{
    public abstract class AttackItem : Item, IItem
    {
        public abstract int DamageDealt { get; }
        public abstract int Range { get; }
    }
}
