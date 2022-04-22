using Advanced_Mandatory_Game.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_Mandatory_Game.Objects
{
    public class WorldObject
    {
        public WorldObject()
        {

        }
        public int ID { get; set; }
        public string Name { get; set; }
        public bool Lootable { get; set; }
        //Removable is ment to be destructable 
        public bool Removable { get; set; }
        public List<Item> ContainedItems { get; set; }        
    }
}
