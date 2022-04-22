using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_Mandatory_Game.Potions
{
    public class Potion
    {
        private int _duration = 10;
        private bool _using = false;

        public int ID { get; set; }
        public int Duration { get { return _duration; } set {_duration=value; } }
        public bool Using { get {return _using; } set { _using=value; } }

        //public void Drink()
        //{
        //    Using = true;
        //    while (Using == true)
        //    {

        //       int newDuration= _duration - 1;
        //    }
        //}
    }
}
