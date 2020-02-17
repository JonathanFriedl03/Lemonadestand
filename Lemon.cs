using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    class Lemon : Item
    {
        // member variables (HAS A)
        public static double Price;
        static Lemon()
        {
            Price = .50;
        }
        // constructor (SPAWNER)
        public Lemon()
        {
            name = "lemon";
            
        }

        // member methods (CAN DO)
    }
}
