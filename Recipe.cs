using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    class Recipe
    {
        public int amountOfLemons;
        public int amountOfSugarCubes;
        public int amountOfIceCubes;
        public double pricePerCup;
        public string sweetness;
        public Recipe()
        {
               
        }

        public void CreateRecipe(Player player)
        {
            try
            {
                bool inventoryCheck = false;
                do
                {
                   Console.WriteLine($"How many lemons do you want to use? available ={player.inventory.lemons.Count}");
                   amountOfLemons = int.Parse(Console.ReadLine());
                   inventoryCheck = CheckInventory(amountOfLemons, player.inventory.lemons.Count);
                } while (inventoryCheck == false);
                do 
                {
                    Console.WriteLine($"How many Sugar Cubes do you want to use? available ={player.inventory.sugarCubes.Count}");
                    amountOfSugarCubes = int.Parse(Console.ReadLine());
                    inventoryCheck = CheckInventory(amountOfSugarCubes, player.inventory.sugarCubes.Count);
                } while (inventoryCheck == false);
                do
                {
                    Console.WriteLine($"How many Ice Cubes do you want to use? available ={player.inventory.iceCubes.Count}");
                    amountOfIceCubes = int.Parse(Console.ReadLine());
                    inventoryCheck = CheckInventory(amountOfIceCubes, player.inventory.iceCubes.Count);
                } while (inventoryCheck == false);
              
                    Console.WriteLine("How much do you want to sell each cup of Lemonade for?");
                pricePerCup = double.Parse(Console.ReadLine());
                Console.Clear();
            }
            catch (FormatException)
            {
                Console.WriteLine("Not a valid choice");
                CreateRecipe(player);
            }

        }
        public bool CheckInventory(int numberOf, int stock)
        {

            if (numberOf > stock)
            {
                return false;
            }
            else
            {
                return true;
            }     
        
        }
       public void DetermineSweetSour()
        {

            if (amountOfLemons <= 5 && amountOfIceCubes >= 15 && amountOfSugarCubes <= 10)
            {
                sweetness = "Watery";
            }
            else if (amountOfLemons >= 15 && amountOfIceCubes <= 15 && amountOfSugarCubes <= 10)
            {
                sweetness = "Sour";
            }
            else if (amountOfLemons >= 6 && amountOfLemons <= 15 && amountOfIceCubes <= 20  && amountOfSugarCubes >=5 && amountOfSugarCubes <= 15)
            {
                sweetness = "Just Right";
            }
            else if(amountOfLemons <= 10 && amountOfIceCubes <= 20 && amountOfSugarCubes >= 10 )
            {
                sweetness = "Sweet";
            }

        }
    }
}
