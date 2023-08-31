


/*Data abstraction is the process of hiding certain details and showing only essential information to the user.*/
/*Abstraction can be achieved with either abstract classes or interfaces*/


using System;
    namespace Abstraction
{
    abstract class Animal
    {
        public abstract void animalSound();   // Abstract method (does not have a body)

        public void animalName() // Regular method
        {
            Console.WriteLine("This is the name of animal.");
        }
    }

    class Pig : Animal  // Derived class (inherit from Animal)
    {
        public override void animalSound()   // The body of animalSound() is provided here
        {
            Console.WriteLine("chu-chu");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            /*Animal animalObject = new Animal(); => This will generate an error because abstract class can't have an object.
            * To access the abstract class, it must be inherited from another class.*/

            Pig pigObject = new Pig(); // Create a Pig object
            pigObject.animalSound(); // Call the abstract method
            pigObject.animalName(); // Call the regular method



            Crow crowObject = new Crow();
            Console.WriteLine(crowObject.birdName("Crow"));
            crowObject.birdSound();
            Console.WriteLine(crowObject.birdArea());
        }
    }
} 
