using Advanced_Mandatory_Game.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_Mandatory_Game.Items
{
    class Sword : AttackItem
    {
        public override string Name { get { return "Sword"; } }
        public override int DamageDealt { get { return 35; } }
        public override int Range { get { return 1; } }
    }
}
