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

        public Weather(int temperature, string condition)
        {
            this.condition = condition;
            this.temperature = temperature;
            weatherConditions = new List<string>() { };
        }
    }
}
