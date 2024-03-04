using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    class Program
    {
        enum cities
        { Agra, Banglore, Chennai, Delhi, Hyderabad, Kolkata, Mumbai, Vizag }
        struct Customer
        {
            public int custrating;
        }
        public static void Enum_Operations()
        {
            foreach(int x in Enum.GetValues(typeof(cities))){
                {
                    if (x == 1)
                        Console.WriteLine(Enum.GetName(typeof(cities), x) + "Is a Garden City");
                    else if (x == 2)
                        Console.WriteLine(Enum.GetName(typeof(cities), x) + "Is a Temple city");
                    else if (x == 6)
                        Console.WriteLine(Enum.GetName(typeof(cities), x) + "Is a Finacial City");
                    else Console.WriteLine(Enum.GetName(typeof(cities), x));


                }
            }
        }
        static void Main(string[] args)
        {

        }
    }
}
