using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleClass
{
    class Car
    {
        /*variables/fields created*/
        public string name;
        public string color;
        public int topspeed;

        /*methods created*/
        public void Country(string country, int zipcode)
        {
            Console.WriteLine("Country: " + country);
            Console.WriteLine("Zipcode: " + zipcode);
        }
        public string Person( string pname, string address)
        {
            return "Owner's name: " + pname + "\n" + "Address: " + address;
        }
        public void PurchasedYear(int year)
        {
            Console.WriteLine("Purchased year: "+ year);
        }
    }
}
