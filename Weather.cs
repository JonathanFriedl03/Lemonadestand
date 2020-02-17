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
            temperature = rnd.Next(55, 105);
            TodaysWeather(rnd);
        }
        public void TodaysWeather(Random rnd)
        {
            
            condition = weatherConditions[rnd.Next(0,4)];
            Console.WriteLine($"{condition} {temperature}");
           
        }
       
    }
}
