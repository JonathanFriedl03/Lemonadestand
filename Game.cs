using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{//solid principle used in Recipe Class on DetermineSweetness method-single responsibility  
    //open closed principle used in player class WeeklyProfitLoss method 
    class Game
    {
        // public Day day;
        public Store store;
        public Player player;
        public List<Day> days;
        Random rnd = new Random();

        // List<Player> players;
        public Game()
        {
            days = new List<Day>();
           
            // (loop) fill up the List<Day>


            for(int i = 0; i < 7; i++)
            {
                days.Add(new Day(rnd, i+1));               
            }

            //players = new List<Player>();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
        }

        public void StartUp()
        {
            store = new Store();
            DisplayGameRules();
            GetName();
            for (int i = 0; i < days.Count; i++)
            {

                if (player.wallet.Money > 0)
                {
                    days[i].DisplayTodaysWeather(rnd);
                    player.inventory.DisplayInventory(player);
                    BuyProduct(player, days[i]);
                    player.recipe.CreateRecipe(player);
                    player.inventory.RecipeUsed(player);
                    player.recipe.DetermineSweetSour();

                    for (int j = 0; j < days[i].customers.Count; j++)
                    {
                        days[i].customers[j].WillCustomerBuy(player, days[i]);
                    }
                    days[i].GetDailySales(player, days[i].buyerCount);
                    player.wallet.GetPaid(days[i], player);
                    player.WeeklyProfitLossReport(days[i]);

                    
                }
                else if (days[i].currentDay == 7)
                {
                    Console.WriteLine($"A week has passed the game is over you have ${player.wallet.Money}!");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine($"Sorry {player.name} the game is over your wallet is empty!");
                    Console.ReadLine();
                }


            }


            Console.WriteLine($"A week has passed the game is over you have ${player.wallet.Money} in your wallet, your weekly sales are ${player.weeklySales} and your weekly supplies cosgt you{player.weeklyMoneyUsedOnSupplies}");
            Console.WriteLine("Thanks for playing my version of Lemonade stand!");
            Console.ReadLine();



        }
        public void DisplayGameRules()
        {
            Console.WriteLine("Welcome to LEMONADE STAND! A game about supply & Demand!\n");
            Console.WriteLine("You will be given the duty of running a Lemonade Stand! \n\nYou will start with $20.00 and will have to track your supplies needed for the stand to meet customer demands!\n");
            Console.WriteLine("The basic object of the game is to have made a profit of money after 7 days! If you lose all your money before then you lose.");
           // var numberOfPlayers = Int32.Parse(Console.ReadLine());
            //Console.Clear();
            Console.ReadLine();
            Console.Clear();
          

        }


        public string GetName()//Single responsibility
        {
            Console.WriteLine("Player Please enter your name. Then press Enter");
            string newName = Console.ReadLine();
            player = new Player(newName);
            Console.Clear();
            return newName;
            

        }


    public void BuyProduct(Player player, Day day)
        {
            
            store.SellLemons(player,day);
            store.SellIceCubes(player, day);
            store.SellSugarCubes(player,day);
            store.SellCups(player, day);
            player.pitcher.cupsLeftinPitcher = player.inventory.cups.Count;


          
            // DisplayGameRules();
            Console.Clear();
            //    int numberOfLemons = Int32.Parse(Console.ReadLine());
            //    player.inventory.AddLemonsToInventory(numberOfLemons);
        }
        

      
    }
}

