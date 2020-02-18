using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    class Pitcher 
    {
        public int cupsLeftinPitcher;
        public string name;
       

         public Pitcher()
        {
            name = "Pitcher";
            cupsLeftinPitcher = 0;

        }

        public void RecipeToPitcher(Player player)
        {
          
            player.inventory.lemons.RemoveRange(0, player.recipe.amountOfLemons);
            player.inventory.sugarCubes.RemoveRange(0, player.recipe.amountOfSugarCubes);
            player.inventory.iceCubes.RemoveRange(0, player.recipe.amountOfIceCubes);
            cupsLeftinPitcher++;

        }
    }
}
