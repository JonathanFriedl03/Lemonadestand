using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    class Pitcher : Item
    {
        public int cupsLeftinPitcher;

         public Pitcher()
        {
            name = "Pitcher";
            cupsLeftinPitcher = 10;
        }

        public void PourLemonade()
        {

        }
    }
}
