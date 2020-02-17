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
        Random random = new Random();

        public Weather()
        {
            
            weatherConditions = new List<string>() {"Cloudy", "Rainy", "Sunny", "Foggy" };
            temperature = random.Next(55, 105);
            
        }
        public void TodaysWeather()
        {
            int random = this.random.Next(0, 4);
            condition = weatherConditions[random];
            Console.ReadLine();
        }
       
    }
}
