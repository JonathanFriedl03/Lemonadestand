using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    class Day
    {
        public List<int> daysOfMonth;
        public Customer customers;
        public Weather weather;
        public int currentDay;
        public Day(Random rnd)
        {
            customers = new Customer(rnd);
            weather = new Weather(rnd);
            currentDay = 1;
            daysOfMonth = new List<int>() { 1, 2, 3, 4, 5, 6, 7 };
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
