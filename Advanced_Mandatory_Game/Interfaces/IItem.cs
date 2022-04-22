using Advanced_Mandatory_Game.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_Mandatory_Game.Interfaces
{
    public interface IItem
    {
        public int ID { get; set; }
        public string Name { get;}
        public int Durability { get;}
        public int InventorySpaceTaken { get;}
        //Failed to implement
        //public void ItemBreak(Item i);
    }
}
