using Advanced_Mandatory_Game.Creatures;
using Advanced_Mandatory_Game.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_Mandatory_Game.Items
{
    public class Item : IItem
    {
        private int _durability = 100;
        public int _inventorySpaceTaken = 1;

        public Item()
        {
            _durability = Durability;
        }

        public int ID { get; set; }

        public virtual string Name { get; set; }

        public int Durability { get { return _durability; } set { _durability = value; } }

        public int InventorySpaceTaken { get { return _inventorySpaceTaken; } set { _inventorySpaceTaken = value; } }        

        //public void ItemBreak(Item i)
        //{
        //    Player p = new Player();
        //    if (i.Durability == 0)
        //    {
        //        p.Inventory.Remove(i);
        //        Console.WriteLine($"The Item {i.Name} broke in your hands");
        //    }
        //}
    }
}
