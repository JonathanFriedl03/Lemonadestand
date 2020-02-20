using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    class Day
    {
        public List<Customer> customers;
        public int buyerCount;
        public Weather weather;
        public int currentDay;
        public double moneyUsedOnSupplies;
        public double todaysProfitLoss;
        public double todaysSales;

        public Day(Random rnd, int dayNumber)
        {
            customers = new List<Customer>();
            weather = new Weather(rnd);
            currentDay = dayNumber;
            moneyUsedOnSupplies = 0;
            todaysSales = 0;
            todaysProfitLoss = 0;
            buyerCount = 0;
            GetCustomers(rnd,weather);
        }
         public void DisplayTodaysWeather(Random rnd)
        {
            weather.TodaysWeather(rnd);
            Console.WriteLine($"\nOn day {currentDay} the forecast is {weather.condition} and the temperature is {weather.temperature}.\n");
            Console.ReadLine();
            
        }


        public void GetCustomers(Random random,Weather weather)
        {
            int numberOfCustomers = 0;
            if(weather.temperature >= 85 )
            {
                numberOfCustomers = 40;
            }
            else if (weather.temperature >= 75  && weather.temperature <=85)
            {
                numberOfCustomers = 30;
            }
            else if (weather.temperature >= 65 && weather.temperature <= 75)
            {
                numberOfCustomers = 20;
            }
            else if (weather.temperature >= 50 && weather.temperature <= 75)
            {
                numberOfCustomers = 10;
            }
            for (int i = 0; i < numberOfCustomers; i++) { customers.Add(new Customer(random)); }
            
            
        }
        public void GetDailySales(Player player,int buyerCount)
        {
           
            todaysSales = buyerCount * player.recipe.pricePerCup;
            Console.WriteLine($"{player.name} you started the day with ${player.wallet.Money} in your wallet. \n\nToday you spent ${moneyUsedOnSupplies} on supplies to make ${todaysSales} in sales!");
            Console.ReadLine();
            Console.Clear();
           
            if (todaysSales < moneyUsedOnSupplies)
            {
                TodaysProfitLoss(todaysSales, player);
                
            }              
            else if(todaysSales > moneyUsedOnSupplies)
            {
                TodaysProfitLoss(todaysSales, player);
            }
          
            
        }
        private void TodaysProfitLoss(double todaysSales,Player player)
        {
            
            todaysProfitLoss = todaysSales - moneyUsedOnSupplies;
            if(todaysProfitLoss < 0)
            {
                Console.WriteLine($"Today wasn't a good day! You lost ${Math.Abs(todaysProfitLoss)}!");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine($"Today was a good day! You made ${todaysProfitLoss}!\n\n");
                Console.ReadLine();
            }

        }
       
    }
}
