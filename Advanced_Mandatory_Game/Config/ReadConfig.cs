using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Advanced_Mandatory_Game
{
    public class ReadConfig
    {
        public static int WorldSizeX { get; private set; }
        public static int WorldSizeY { get; private set; }


        static string ConfigFilePath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName + "/Config.xml";
        public static void ReadConfiguration()
        {
            XmlDocument xml = new XmlDocument();
            xml.Load(ConfigFilePath);
            XmlNode root = xml.DocumentElement;

            XmlNode worldSizeX = root.SelectSingleNode("XAxisLength");
            if (worldSizeX != null)
            {
                string s = worldSizeX.InnerText.Trim();
                WorldSizeX = Convert.ToInt32(s);
            }

            XmlNode worldSizeY = root.SelectSingleNode("YAxisLength");
            if (worldSizeY != null)
            {
                string s = worldSizeY.InnerText.Trim();
                WorldSizeY = Convert.ToInt32(s);
            }

        }
        
    }
}
