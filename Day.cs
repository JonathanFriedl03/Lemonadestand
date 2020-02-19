using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    class Day
    {
        public List<Day> daysOfMonth;
        public List<Customer> customers;
       
        public Weather weather;
        public int currentDay;
        public Day(Random rnd)
        {
            customers = new List<Customer>();
            weather = new Weather(rnd);
            currentDay = 1;
            daysOfMonth = new List<Day>() ;
            GetCustomers(rnd,weather);
        }
         public void DisplayTodaysWeather(Random rnd)
        {
            weather.TodaysWeather(rnd);
            Console.WriteLine($"\nOn day {currentDay} the forecast is {weather.condition} and the temperature is {weather.temperature}.");
            
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
        public void GetDayOfMonth()
        {
            

            //if (currentDay == 1)
            //{
            //    Console.WriteLine("Day of the month is" + currentDay);
            //}
            //else
            //{
            //    for (int i = 0; i < daysOfMonth.Count; i++)
            //    {
            //        Console.WriteLine(i + daysOfMonth[i]);
            //    }
            //    Console.WriteLine("Day of the month is" + daysOfMonth);
            //}
        }
    }
}
