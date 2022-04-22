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
    public class ArmorFactory : IItemFactory
    {
        //factory design pattern
        public IItem CreateItem(ItemType type)
        {
            if (type == ItemType.Armor) return new Armor();
            if (type == ItemType.Shield) return new Shield();

            throw new Exception($"No class available for type{type}");
        }
    }
}
