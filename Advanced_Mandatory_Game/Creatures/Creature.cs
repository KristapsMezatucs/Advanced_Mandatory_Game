#define TRACE
using Advanced_Mandatory_Game.Interfaces;
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
    public class Creature : ICreature
    {
       
        private int _baseDamage = 10;
        private string _icon;
        private int _health = 100;
        
        public Creature()
        {

        }

        public Creature(string name, Position position)
        {
            _health = Health;
            _baseDamage = Damage;
            name = Name;
            _icon = "X";
            Color = ConsoleColor.Red;
            this.Position = position;
        }

        public int X { get; set; }
        public int Y { get; set; }
        public ConsoleColor Color { get; set; }

        public int ID { get; set; }
        public string Name { get; set; }
        public int Health { get { return _health; } set { _health = value; } }
        public Position Position { get; set; }
        public int Damage { get { return _baseDamage; } set { _baseDamage = value; } }


        public List<AttackItem> attackItems = new List<AttackItem>();
        public List<DefenceItem> defenceItems = new List<DefenceItem>();

        public int Hit(Player p)
        {
            Creature c = new Creature();
            if (attackItems != null)
            {
                int totalDamage = c.Damage + attackItems.Sum(AttackItem => AttackItem.DamageDealt);
                int remainingHealth = p.Health - totalDamage;
                p.Health = remainingHealth;
            }
            else
            {
                int attack = p.Health - c.Damage;
                p.Health = attack;
            }
            return p.Health;
        }

        public virtual int ReceiveHit(Player p)
        {
            Creature c = new Creature();
            if (defenceItems != null)
            {
                var lessDmg = p.Damage - defenceItems.Sum(DefenceItem => DefenceItem.DamageReduction);
                var remainingHealth = c.Health - lessDmg;
                c.Health = remainingHealth;
            }
            else
            {
                int attacked = c.Health - p.Hit(this);
                c.Health = attacked;
            }           
            return c.Health;
        }

        //Failed to implement
        //public virtual WorldObject DropLoot()
        //{
        //    Item i = new Item();
        //    WorldObject wo = new WorldObject();
        //    Creature c = new Creature();
        //    if (c.Health <= 0)
        //    {
        //        Position deathPlace = new Position();

        //    }
        //}


        public bool IsDead()
        {
            if (Health is <= 0)
            {
                Logger.ts.TraceEvent(TraceEventType.Information, 0, "Nice going, you just killed a guy...");
                
                //Logger.Logging(TraceEventType.Information, "The creature has died. You killed it. You should feel bad.");
                Logger.ts.Flush();
            }
            return Health is <= 0;
        }

    }
}
