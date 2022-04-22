using Advanced_Mandatory_Game.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_Mandatory_Game.Items
{
    public class Armor : DefenceItem
    {        
        public override int DamageReduction { get { return 25; } }
        public override string Name { get { return "Armor"; } }
    }
}
