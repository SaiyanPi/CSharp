using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    public class Class1
    {
        private double account;
        private int pin;
        private string name;

        public double Account //PROPERTY
        {
            get
            {
                return account;
            }
            set
            {
                account = value;
            }
        }
        public int Pin //PROPERTY
        {
            get
            {
                return pin;
            }
            set
            {
                pin = value;
            }
        }
        public string Name //PROPERTY
        {
            get
            {
                return name;
            }
            set
            {
                name = value + " musk"; //HAVING A LOGIC WHILE SETTING A VALUE
            }
        }


        public Class1(string name, double account, int pin) //CONSTRUCTOR
        {
            this.Name = name;
            this.Account = account;
            this.Pin = pin;

        }

        public void Print()
        {
            Console.WriteLine($"detail: {name}, {account}, {pin}");
        }
    }

}
