using Advanced_Mandatory_Game.Creatures;
using Advanced_Mandatory_Game.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_Mandatory_Game.Items
{
    class Shield : DefenceItem
    {
        public override int DamageReduction { get { return 15; } }
        public override string Name { get {return "Shield"; } }
    }
}
