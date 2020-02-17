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
        

        public Customer(Random rnd)
        {
            
            names = new List<string>() {"Steve","Stacy","Juan","Juanita","Amelia","Isaac","Ezra","Genesis","Emeli","Jonathan","Elaine","Alejandra","Emilio","Nehemiah","Manuel",};
            GetCustomer(rnd);
        }
        public void GetCustomer(Random rnd)
        {
            
            name = names[rnd.Next(0,15)];
            
        }
        
    }
}
