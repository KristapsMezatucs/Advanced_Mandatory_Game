using Advanced_Mandatory_Game.Items;
using Advanced_Mandatory_Game.Objects;
using Advanced_Mandatory_Game.World;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_Mandatory_Game.Creatures
{
    public class Player
    {
        private int _health = 100;
        private int _baseDamage = 10;
        private int _equipmentSlots = 2;
        //private Item[] _inventorySpace = new Item[5];
        private string _icon;

        public Player()
        {

        }

        public Player(string name, Position position)
        {
            _health = Health;
            _baseDamage = Damage;
            _equipmentSlots = EquipmentSlots;
            name = Name;
            Position = position;
            _icon = "@";
            Color = ConsoleColor.White;
        }

        public Position Position { get; set; }
        public ConsoleColor Color { get; set; }


        public int Health { get { return _health; } set { _health = value; } }

        //The space player has in the inventory | Failed to implement
        //public Item[] InventorySpace { get { return _inventorySpace; } set { _inventorySpace = value; } }

        public int EquipmentSlots { get { return _equipmentSlots; } set { _equipmentSlots = value; } }

        public string Name { get; set; }

        public int Damage { get { return _baseDamage; } set { _baseDamage = value; } }

        //The actual inventory list | Failed to implement
        //public List<Item> Inventory { get; set; }
        public List<AttackItem> attackItems = new List<AttackItem>();
        public List<DefenceItem> defenceItems = new List<DefenceItem>();


        public int Hit(Creature c)
        {
            Player p = new Player();
            if (attackItems != null)
            {
                int totalDamage = p.Damage + attackItems.Sum(AttackItem => AttackItem.DamageDealt);
                int remainingHealth = c.Health - totalDamage;
                c.Health = remainingHealth;
            }
            else
            {
                int attacked = c.Health - Damage;
                c.Health = attacked;
            }
            return c.Health;
        }

        public int ReceiveHit(Creature c)
        {
            Player p = new Player();
            if (defenceItems != null)
            {
                var lessDmg = c.Damage - defenceItems.Sum(DefenceItem => DefenceItem.DamageReduction);
                var remainingHealth = p.Health - lessDmg;
                p.Health = remainingHealth;
            }
            else
            {
                int attacked = p.Health - c.Hit(this);
                p.Health = attacked;
            }
            return p.Health;

        }

        // Failed to implement
        //public List<Item> PickUpLoot()
        //{
        //    WorldObject wo = new WorldObject();
        //    if (Inventory.Count < InventorySpace.Length && wo.Lootable == true)
        //    {
        //        foreach (Item item in wo.ContainedItems)
        //        {
        //            Inventory.Add(item);
        //            wo.ContainedItems.Remove(item);
        //        }
        //    }
        //    Console.WriteLine("Your inventory is full");
        //    return Inventory;
        //}

        public bool IsDead()
        {
            if (Health is <= 0)
            {
                Logger.ts.TraceEvent(TraceEventType.Information, 0, "You have died. Next time try not to suck so much");
                Logger.ts.Flush();
            }
            return Health is <= 0;
        }

    }
}
