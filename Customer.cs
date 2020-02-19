using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    class Customer
    {
        public List<string> names;
        public string name;
        public List<string> preferences;
        public string preference;
        public List<double> paypreferences;
        public double paypreference;


        public Customer(Random rnd)
        {            
            names = new List<string>() {"Steve","Stacy","Juan","Juanita","Amelia","Isaac","Ezra","Genesis","Emeli","Jonathan","Elaine","Alejandra","Emilio","Nehemiah","Manuel",};
            preferences = new List<string>() { "Sweet", "Sour", "Just Right", "Watery" };
            paypreferences = new List<double>() { .55, .60, .70, .75, .80, .85, .90, .95, 1.0, 1.10, 1.15, 1.20, 1.25, 1.35, 1.4, 1.5 };
            name = names[rnd.Next(names.Count)];
            preference = preferences[rnd.Next(preferences.Count)];
            paypreference = paypreferences[rnd.Next(paypreferences.Count)];            
        }
        public void WillCustomerBuy(Player player,Day day)
        {
            
                        
            if(paypreference >=  player.recipe.pricePerCup && preference == player.recipe.sweetness && player.inventory.cups.Count > 0)
            {

                    player.wallet.SalesFromTransaction(player.recipe.pricePerCup);                 
                    player.pitcher.cupsLeftinPitcher--;
                    player.inventory.cups.Remove(player.inventory.cups[0]);
                Console.WriteLine($"{player.name} you made a sale! {name} bought a cup of Lemonade!");
                   day.buyerCount++;
                Console.ReadLine();
                Console.Clear();

            }
            else if(player.inventory.cups.Count == 0)
                
            {
                Console.WriteLine("You're out of cups! Let's move on to the next day!");
                Console.ReadLine();
                day.currentDay++;
                Console.Clear();
            }
            else if(paypreference < player.recipe.pricePerCup && preference == player.recipe.sweetness)
            {
                Console.WriteLine($"{name} will not pay {player.recipe.pricePerCup} per cup");
                Console.ReadLine();
                Console.Clear();
            }
            else if (paypreference >= player.recipe.pricePerCup && preference != player.recipe.sweetness)
            {
                Console.WriteLine($"{name} likes Lemonade {preference} you made it {player.recipe.sweetness}! \n{player.name} if you want to make more sales you need to make more variations of Lemonade!");
                Console.ReadLine();
                Console.Clear();
            }
            else
            {
                Console.WriteLine($"{name} will not pay {player.recipe.pricePerCup} per cup & likes Lemonade {preference} you made it {player.recipe.sweetness}!");
                Console.ReadLine();
                Console.Clear();
                
            }
        }

       
    }
}
