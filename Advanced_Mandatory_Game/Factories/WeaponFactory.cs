using Advanced_Mandatory_Game.Enums;
using Advanced_Mandatory_Game.Interfaces;
using Advanced_Mandatory_Game.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_Mandatory_Game.Factories
{
    public class WeaponFactory : IItemFactory
    {
        public IItem CreateItem(ItemType type)
        {
            if (type == ItemType.Melee) return new Sword();
            if (type == ItemType.Ranged) return new Bow();

            throw new Exception($"No class available for type {type}");
        }
    }
}
