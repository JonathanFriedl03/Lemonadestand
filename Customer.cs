using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    class Customer
    {
        public List<string> names;
        public string name;
        public List<string> preferences;
        public string preference;
        public List<double> paypreferences;
        public double paypreference;


        public Customer(Random rnd)
        {            
            names = new List<string>() {"Steve","Stacy","Juan","Juanita","Amelia","Isaac","Ezra","Genesis","Emeli","Jonathan","Elaine","Alejandra","Emilio","Nehemiah","Manuel",};
            preferences = new List<string>() { "Sweet", "Sour", "Just Right", "Watery" };
            paypreferences = new List<double>() { .55, .60, .70, .75, .80, .85, .90, .95, 1.0, 1.10, 1.15, 1.20, 1.25, 1.35, 1.4, 1.5 };
            name = names[rnd.Next(names.Count)];
            preference = preferences[rnd.Next(preferences.Count)];
            paypreference = paypreferences[rnd.Next(paypreferences.Count)];            
        }
        public void WillCustomerBuy()
        {
            bool customerWillBuy = false;
            if()
            {

            }
        }

    }
}
