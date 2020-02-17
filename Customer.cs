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
        Random rnd = new Random();

        public Customer(string name)
        {
            
            names = new List<string>() {"Steve","Stacy","Juan","Juanita","Amelia","Isaac","Ezra","Genesis","Emeli","Jonathan","Elaine","Alejandra","Emilio","Nehemiah","Manuel",};

        }
        public void GetCustomer()
        {
            int rnd = this.rnd.Next(0, 14);
            name = names[rnd];
            Console.ReadLine();
        }
        
    }
}
