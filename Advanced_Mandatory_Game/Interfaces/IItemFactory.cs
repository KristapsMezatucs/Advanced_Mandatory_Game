using Advanced_Mandatory_Game.Enums;
using Advanced_Mandatory_Game.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_Mandatory_Game.Interfaces
{
    public interface IItemFactory
    {
        IItem CreateItem(ItemType type);       
    }
}
