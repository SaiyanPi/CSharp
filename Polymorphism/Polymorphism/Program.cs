
/*Polymorphism means "many forms", and it occurs when we have many classes that are related to each other by inheritance.*/
/* Inheritance lets us inherit fields and methods from another class. Polymorphism uses those methods to perform different tasks.
 * This allows us to perform a single action in different ways.*/

/*For example, think of a base class called Animal that has a method called animalSound().
 * Derived classes of Animals could be Pigs, Cats, Dogs, Birds - And they also have their own implementation of an animal sound (the pig oinks, and the cat meows, etc.):*/


using System;
namespace Polymorphism
{
   
    class Animal //parent class
    {
        public virtual void AnimalSound() //'virtual' keyword to the method inside the base class
        {
            Console.WriteLine("The animal makes a sound");
        }
    }
    //RUN TIME/DYNAMIC POLYMORPHISM = METHOD OVERRIDE
    //COMPILE TIME/STATIC POLYMORPHISM = METHOD OVERLOADING
    class Pig : Animal //child class
    {
        public override void AnimalSound() //METHOD OVERRIDE, override keyword for each derived class methods
        {
            Console.WriteLine("chu-chu");
        }
    }
    class Dog : Animal //child class
    {
        public override void AnimalSound() //METHOD OVERRIDE, override keyword for each derived class methods
        {
            Console.WriteLine("woof-woof");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Animal AnimalObj = new Animal(); //create animal object
            Pig PigObj = new Pig(); //create pig object
            Animal DogObj = new Dog(); //create dog object
            Cat catobj = new Cat();

            AnimalObj.AnimalSound();
            PigObj.AnimalSound();
            DogObj.AnimalSound();
            catobj.AnimalSound();

        }
    }
}
