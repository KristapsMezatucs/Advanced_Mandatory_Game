using Advanced_Mandatory_Game.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_Mandatory_Game.World
{
    public class MyWorld : IMyWorld
    {
        public int MaxX { get; set; }
        public int MaxY { get; set; }

        public MyWorld()
        {
            GetConfig();
        }

        public void GetConfig()
        {
            ReadConfig.ReadConfiguration();
            MaxX = ReadConfig.WorldSizeX;
            MaxY = ReadConfig.WorldSizeY;
        }

    }
}
