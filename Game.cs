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
        public Recipe recipe;
        public Player player;
        public List<Day> days;
        Random rnd = new Random();

        // List<Player> players;
        public Game()
        {
           
            days = new List<Day>();
            //players = new List<Player>();
           
        }

        public void StartUp()
        {
            DisplayGameRules();
            GetName();
            DisplayTodaysData(rnd);
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
        public void DisplayTodaysData(Random rnd)
        {
            Day today = new Day(rnd);
            Console.WriteLine($"On day {today.currentDay} the forecast is {today.weather.condition} and the temperature is {today.weather.temperature}.");
        }
        public void DisplayTodaysInventory()
        {
            Console.WriteLine();
        }
    }
}

