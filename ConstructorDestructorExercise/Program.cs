using System;
namespace Exercise
{
    class Phone
    {
        public string pname;
        public Phone(string name)
        {
            this.pname = name; //pname = name; 'this' can be used refers to the fields of current class.
            Console.WriteLine($"This is Constructor of {name}");
        }

        //destructor
        ~Phone()
        {
            Console.WriteLine("Destructor called");
        }
        public void charger()
        {
            Console.WriteLine($"This is a method charger of {pname}");
        }

    }
    class Program
    {
      
        static void Main(string[] args)
        {
            Phone pobject = new Phone(name: "samsung");
            pobject.pname = "redmi";
            pobject.charger();


        }
    }
}