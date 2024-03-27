/*Another way to achieve abstraction in C#*/
/*An interface is a completely "abstract class", which can only contain abstract methods and properties (with empty bodies)*/
/*It is considered good practice to start with the letter "I" at the beginning of an interface, as it makes it easier for 
 * yourself and others to remember that it is an interface and not a class.

By default, members of an interface are abstract and public.

Note: Interfaces can contain properties and methods, but not fields.*/
using System;
using System.ComponentModel;
using System.Xml.Linq;

namespace Interface
{
    // interface
    interface IAnimal
    {
        /*string animalname; =>Interface cannot contain fields.*/
        string animalType { get; set;}
        void animalName(string name); // interface method (does not have a body)
                                      // By default, members of an interface are abstract and public. no need to write 'public void animalName(string name);'
        //public astract void animalDescription(string description); //compile time error
        void animalSound();  // interface method (does not have a body)

        /*An interface cannot contain a constructor(as it cannot be used to create objects)*/

    }
    interface ICategory
    {
        void CateName(string name);
    }



    class Parrot : IAnimal, ICategory // multiple inheritance: Parrot "implements" the IAnimal and ICategory interface
    {
        public string animalType 
        {
            get { return "domestic"; }
            set { }
        }
        public void animalSound() // The body of animalSound() is provided here
        {
            Console.WriteLine("turr-turr");
        }
        public void animalName(string name)
        {
            Console.WriteLine($"{name}");
        }
        public void CateName(string name)
        {
            Console.WriteLine(name);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Parrot parrotObject = new Parrot();
            Console.WriteLine(parrotObject.animalType);
            parrotObject.animalName("Parrot");
            parrotObject.animalSound();
            parrotObject.CateName("Bird");
            


        }
    }
}


/*Notes on Interfaces:
Like abstract classes, interfaces cannot be used to create objects (in the example above, it is not possible to create an "IAnimal" object in the Program class)
Interface methods do not have a body - the body is provided by the "implement" class
On implementation of an interface, you must override all of its methods
Interfaces can contain properties and methods, but not fields/variables
Interface members are by default abstract and public
An interface cannot contain a constructor (as it cannot be used to create objects)

Why And When To Use Interfaces?
1) To achieve security - hide certain details and only show the important details of an object (interface).

2) C# does not support "multiple inheritance" (a class can only inherit from one base class). 
However, it can be achieved with interfaces, because the class can implement multiple interfaces. 
Note: To implement multiple interfaces, separate them with a comma (see above).*/