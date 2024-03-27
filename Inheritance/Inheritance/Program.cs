using System;
namespace Inheritance
{
    class Test
    {
        public void testMethod()
        {
            Console.WriteLine("test");
        }
    }
    class Vehicle // PARENT CLASS
    {
        public string brand = "Mustang"; //field
        public void Horn() // method
        {
            Console.WriteLine("peep...peep....peep");
        }
    }

    class Car: Vehicle  // CHILD CLASS INHERITS FIELDS AND METHODS OF PARENT CLASS | CANNOT INHERIT FROM MULTIPLE BASE CLASS( class Car:Vehicle, Test)
    {
        public string name = "hellfire";
    }

    sealed class Boat  //IT WILL NOT INHERIT OTHER CLASS OR CAN'T HAVE A CHILD CLASS
    {
        string message = "I am sealed";
    }
   /* class Ship : Boat // This will generate error
    {

    }*/
    class Program
    {
        static void Main(string[] args)
        {
            Car Sport = new Car(); //CHILD CLASS OBJECT
            Sport.Horn(); //object of child class accessing method of parent class.
            Console.WriteLine(Sport.name);
            Console.WriteLine("I have a " + Sport.brand + " " + Sport.name); //object of child class accessing fields of parent class and it's own field

        }
    }
}
