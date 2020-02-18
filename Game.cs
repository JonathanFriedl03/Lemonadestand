using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    class Game
    {
        public Day day;
        public Store store;
        public Player player;
        public List<Day> days;
        Random rnd = new Random();

        // List<Player> players;
        public Game()
        {
             day = new Day(rnd);
             store = new Store();
            //players = new List<Player>();
            
        }

        public void StartUp()
        {
            
           // DisplayGameRules();
            GetName();
            day.DisplayTodaysWeather(rnd);
           
            // DisplayTodaysInventory();
            BuyProduct(player);
            player.recipe.CreateRecipe(player);
            player.pitcher.RecipeToPitcher(player);
        }
        public void DisplayGameRules()
        {
            Console.WriteLine("Welcome to LEMONADE STAND! A game about supply & Demand!\n");
            Console.WriteLine("You will be given the duty of running a Lemonade Stand! \n\nYou will start with $20.00 and will have to track your supplies needed for the stand to meet customer demands!\n");
            Console.WriteLine("The basic object of the game is to have made a profit of money after 7 days! If you lose all your money before then you lose.");
           // var numberOfPlayers = Int32.Parse(Console.ReadLine());
            //Console.Clear();
            Console.WriteLine("Please enter a user name!");
            string userName = Console.ReadLine();
          

        }


        public string GetName()
        {
            Console.WriteLine("Player Please enter your name. Then press Enter");
            string newName = Console.ReadLine();
            player = new Player(newName);
            return newName;

        }
        //private void GameSetup( string userName)
        //{
        //    for (int i = 0; i < numberOfPlayers; i++)
        //    {
        //        Player player = new Player(userName);
        //        players.Add(player);
        //    }


        //}
        //public void DisplayTodaysData(Random rnd)
        //{
        //    Day today = new Day(rnd);
        //    Console.WriteLine($"\nOn day {today.currentDay} the forecast is {today.weather.condition} and the temperature is {today.weather.temperature}.");
        //    Console.WriteLine($"\nYou have {player.inventory.lemons.Count} lemons, {player.inventory.sugarCubes.Count} sugar cubes, {player.inventory.iceCubes.Count} ice cubes, and {player.inventory.cups.Count} cups.");
        //    Console.WriteLine($"\nBased upon the weather determine how much product to stock up on to make Lemonade! \n\nOne pitcher makes 10 cups of Lemonade.\n\nA pitcher has 30 Ice Cubes, 10 Lemons, and either 0, 10, or 20 sugar Cubes. Depending on how sweet or sour you want it!\n\nLets start with Lemons...");
            
        //}
        public void BuyProduct(Player player)
        {
            
            store.SellLemons(player);
            store.SellIceCubes(player);
            store.SellSugarCubes(player);
            store.SellCups(player);
          
            Console.WriteLine("Great now we can make Lemonade!");
        //    int numberOfLemons = Int32.Parse(Console.ReadLine());
        //    player.inventory.AddLemonsToInventory(numberOfLemons);
        }

      
    }
}

