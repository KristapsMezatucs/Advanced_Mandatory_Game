using Advanced_Mandatory_Game;
using Advanced_Mandatory_Game.Creatures;
using Advanced_Mandatory_Game.Enums;
using Advanced_Mandatory_Game.Factories;
using Advanced_Mandatory_Game.Interfaces;
using Advanced_Mandatory_Game.World;
using StateMachineLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RunGame
{
    public class ItemCreator
    {
        public static IItem GetWeaponType(WeaponFactory factory)
        {
            Random random = new Random();
            int rand = random.Next(2);
            if (rand is 0)
            {
                IItem rangeWeapon = factory.CreateItem(ItemType.Ranged);
                return rangeWeapon;
            }
            else
            {              
                IItem meleeWeapon = factory.CreateItem(ItemType.Melee);
                return meleeWeapon;
            }
        }

        public static IItem GetArmorType(ArmorFactory factory)
        {
            Random random = new Random();
            int rand = random.Next(2);
            if (rand is 0)
            {
                IItem shield = factory.CreateItem(ItemType.Shield);
                return shield;
            }
            else
            {
                IItem armor = factory.CreateItem(ItemType.Armor);
                return armor;
            }
        }



        public static IItem GetAttackWeapon()
        {
            return GetWeaponType(new WeaponFactory());
        }

        public static IItem GetDefenseWeapon()
        {
            return GetArmorType(new ArmorFactory());
        }
    }
}
