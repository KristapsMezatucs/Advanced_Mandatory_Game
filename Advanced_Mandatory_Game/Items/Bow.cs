using Advanced_Mandatory_Game.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_Mandatory_Game.Items
{
    public class Bow:AttackItem
    {
        public override string Name { get {return "Bow"; } }

        public override int DamageDealt { get {return 25; } }
        
        public override int Range { get {return 5; } }
    }
}
