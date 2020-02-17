using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    class Game
    {
        Player player;
        List<Day> days;
        int currentDay;
        List<Player> players;
        public Game()
        {
           
            this.currentDay = 1;
        }
        public  void DisplayGameRules()
        {
            Console.WriteLine("Welcome to LEMONADE STAND! A game about supply & Demand!\n");
            Console.WriteLine("You and up to 29 others will be given the duty of running a Lemonade Stand! \n\nYou will start with $20.00 and will have to track your supplies needed for the stand to meet customer demands!\n");
            Console.WriteLine("The basic object of the game is to have the most money after 7 days! If you lose all your money before then you lose.\n\nIt is assumed that each stand is considered a new player.\n\nLet's start with how many stands you'd like to operate..no more than 30.\n");
            int numberOfPlayers = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Please enter a user name!");
            string userName = Console.ReadLine();
            GameSetup(numberOfPlayers,userName);

        }
        private void GameSetup(int numberOfPlayers, string userName)
        {
            for (int i = 0; i < numberOfPlayers; i++)
            {
                Player player = new Player(userName);
                players.Add(player);
            }

        }
    }
}
