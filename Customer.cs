using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    class Customer
    {
        private List<string> names;
        public string name;

        public Customer(string name)
        {
            this.name = name;
            names = new List<string>() { };

        }
    }
}
