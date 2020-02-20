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
        public double weeklyMoneyUsedOnSupplies;
        public double weeklySales;
        public double weeklyProfitLoss;
       
        // constructor (SPAWNER)
        public Player(string name)
        {
            
            pitcher = new Pitcher();
            recipe = new Recipe();
            this.name = name;
            inventory = new Inventory();
            wallet = new Wallet();
            weeklyMoneyUsedOnSupplies = 0;
            weeklyProfitLoss = 0;
            weeklySales = 0;
        }
        public void WeeklyProfitLossReport(Day day)
        {
           
            weeklyProfitLoss = weeklySales - weeklyMoneyUsedOnSupplies;
            if (weeklyProfitLoss < 0)
            {
                Console.WriteLine($"In {day.currentDay} day(s) you've lost ${Math.Abs(weeklyProfitLoss)}! \n\nMaybe switch up your recipe!");
                Console.ReadLine();
                Console.Clear();
            }
            else
            {
                Console.WriteLine($"On day {day.currentDay} you've made ${weeklyProfitLoss}!\n\nYou're doing great don't change a thing!");
                Console.ReadLine();
                Console.Clear();
            }
        }


        // member methods (CAN DO)
    }
}
