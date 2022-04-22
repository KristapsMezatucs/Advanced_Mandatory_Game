using Advanced_Mandatory_Game.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_Mandatory_Game.Interfaces
{
    public interface IWeapon : IItem
    {
        public int DamageDealt { get;}

        public int Range { get; }
    }
}
