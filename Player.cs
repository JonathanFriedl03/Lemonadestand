using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    class Player
    {
        // member variables (HAS A)
        public Inventory inventory;
        public Wallet wallet;
        public Recipe recipe;
        public string name;
        public Pitcher pitcher;
        // constructor (SPAWNER)
        public Player(string name)
        {
            pitcher = new Pitcher();
            recipe = new Recipe();
            this.name = name;
            inventory = new Inventory();
            wallet = new Wallet();
        }
        


        // member methods (CAN DO)
    }
}
