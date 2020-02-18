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

        public Recipe()
        {
               
        }

        public void CreateRecipe(Player player)
        {
            try
            {
                Console.WriteLine($"How many lemons do you want to use? available ={player.inventory.lemons.Count}");
                int lemons = int.Parse(Console.ReadLine());
                CheckInventory(lemons, player.inventory.lemons.Count);
                Console.WriteLine("How many Sugar Cubes do you want to use?");
                int sugarCubes = int.Parse(Console.ReadLine());
                Console.WriteLine("How many Ice Cubes do you want to use?");
                
                int iceCubes = int.Parse(Console.ReadLine());
                Console.WriteLine("How much do ypu want to sell each cup of Lemonade for?");
                int cupPrice = int.Parse(Console.ReadLine());
                amountOfLemons = lemons;
                amountOfSugarCubes = sugarCubes;
                amountOfIceCubes = iceCubes;
                pricePerCup = cupPrice;
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
            if(amountOfLemons >= 0 && amountOfLemons <=5)
            {
                
            }
        }
    }
}
