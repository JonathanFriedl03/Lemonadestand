
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    class Inventory
    {
        // member variables (HAS A)
        public List<Lemon> lemons;
        public List<SugarCube> sugarCubes;
        public List<IceCube> iceCubes;
        public List<Cup> cups;
        
        // constructor (SPAWNER)
        public Inventory()
        {
            lemons = new List<Lemon>();
            sugarCubes = new List<SugarCube>();
            iceCubes = new List<IceCube>();
            cups = new List<Cup>();
           
        }

        // member methods (CAN DO)
        public void AddLemonsToInventory(int numberOfLemons)
        {
            for(int i = 0; i < numberOfLemons; i++)
            {
                Lemon lemon = new Lemon();
                lemons.Add(lemon);
                //wallet.PayMoneyForItems(double transactionAmount);
            }
        }

        public void AddSugarCubesToInventory(int numberOfSugarCubes)
        {
            for(int i = 0; i < numberOfSugarCubes; i++)
            {
                SugarCube sugarCube = new SugarCube();
                sugarCubes.Add(sugarCube);
                
            }
        }

        public void AddIceCubesToInventory(int numberOfIceCubes)
        {
            for(int i = 0; i < numberOfIceCubes; i++)
            {
                IceCube iceCube = new IceCube();
                iceCubes.Add(iceCube);
            }
        }

        public void AddCupsToInventory(int numberOfCups)
        {
            for(int i = 0; i < numberOfCups; i++)
            {
                Cup cup = new Cup();
                cups.Add(cup);
            }
        }
        public void RecipeUsed(Player player)
        {

            player.inventory.lemons.RemoveRange(0, player.recipe.amountOfLemons);
            player.inventory.sugarCubes.RemoveRange(0, player.recipe.amountOfSugarCubes);
            player.inventory.iceCubes.RemoveRange(0, player.recipe.amountOfIceCubes);
           
        }
        public void DisplayInventory(Player player)
        {
            Console.WriteLine($"\nYou have {player.inventory.lemons.Count} lemons, {player.inventory.sugarCubes.Count} sugar cubes, {player.inventory.iceCubes.Count} ice cubes, and {player.inventory.cups.Count} cups.");
            Console.WriteLine($"\nBased upon the weather determine how much product to stock up on to make Lemonade! \n\nLets start with Lemons...");
            Console.ReadLine();
            Console.Clear();

        }
    }
  
}

