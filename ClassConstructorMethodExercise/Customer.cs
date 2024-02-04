using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassConstructorMethodExercise
{
    internal class Customer //class
    {
        public string name; //fields
        public string address;
        public string phone;

        public Customer(string cusname, string cusaddress, string cusphone) //Constructor
        {
            name = cusname;
            address = cusaddress;
            phone = cusphone;
        }
        
        public void TotalCalc() //method
        {
            Console.WriteLine("test");
            
        }
    }
}
