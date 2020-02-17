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
        public Weather weather;
        public int currentDay;
        public Day()
        {
            customers = new List<Customer>() { };
            //weather = new Weather();
            currentDay = 1;
        }
    }
}
