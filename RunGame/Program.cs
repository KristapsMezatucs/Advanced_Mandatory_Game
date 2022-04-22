using Advanced_Mandatory_Game;
using Advanced_Mandatory_Game.Creatures;
using Advanced_Mandatory_Game.Interfaces;
using Advanced_Mandatory_Game.World;
using StateMachineLib;
using System;

namespace RunGame
{
    public class Program
    {

        static void Main(string[] args)
        {
            MyWorld world = new MyWorld();

            Position playerPosition = new Position(5, 5);
            Player p = new Player("Protagonist", playerPosition);
            IItem attackWeapon = ItemCreator.GetAttackWeapon();
            p.attackItems.Add((AttackItem)attackWeapon);


            Position enemyPosition = new Position(5, 7);
            Creature e = new Creature("Big Scary Dude", enemyPosition);
            IItem defenseWeapon = ItemCreator.GetDefenseWeapon();
            e.defenceItems.Add((DefenceItem)defenseWeapon);

            Fight.BeginFight(e, p);

            if(e.Health<=0)
            {
                Console.WriteLine("The enemy died");
            }
            if(p.Health <=0)
            {
                Console.WriteLine("U died");
            }

            Logger.ts.Close();
        }
    }
}
