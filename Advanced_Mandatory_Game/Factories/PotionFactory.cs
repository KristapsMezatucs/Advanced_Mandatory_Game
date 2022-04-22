using Advanced_Mandatory_Game.Enums;
using Advanced_Mandatory_Game.Interfaces;
using Advanced_Mandatory_Game.Potions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_Mandatory_Game.Factories
{
    public class PotionFactory : IPotionFactory
    {
        public IPotion CreatePotion(PotionType type)
        {
            if(type == PotionType.Health) return new HealthPotion();
            if (type == PotionType.Speed) return new SpeedPotion();
            if (type == PotionType.Streangth) return new StrengthPotion();

            throw new Exception($"There is no class for the requested type {type}");
        }
    }
}
