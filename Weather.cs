using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    class Weather
    {
        public string condition;
        public int temperature;
        List<string> weatherConditions;
       

        public Weather(Random rnd)
        {
            
            weatherConditions = new List<string>() {"Cloudy", "Rainy", "Sunny", "Foggy" };
            condition = weatherConditions[rnd.Next(0, 4)];
            temperature = TodaysWeather(rnd);
        }
        public int TodaysWeather(Random rnd)
        {
            if (condition == "Sunny")
            {
                temperature = rnd.Next(75, 105);
            }
            else if (condition == "Cloudy & Humid")
            {
                temperature = rnd.Next(65, 85);
            }
            else if (condition == "Foggy")
            {
                temperature = rnd.Next(5, 75);
            }
            else
            {
                temperature = rnd.Next(55, 70);
            }
            return temperature;



            Console.WriteLine($"{condition} {temperature}");
           
        }
       
    }
}
