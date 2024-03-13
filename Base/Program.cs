using System;

//base keyword is used to access fields, constructors, and methods of a base class.
//can't use inside the static method.
namespace Base
{
    public class Animal
    {
        public string type = "mamal"; //FIELD
        public Animal() //CONSTRUCTOR
        {
            Console.WriteLine("i am animal constructor, i invoke automatically when animal object is created");
        }
        public virtual void intro() //METHOD
        {
            Console.WriteLine("i am an animal");
        }
    }
    public class Cat:Animal
    {
        public string sound = "meow"; //FIELD
        public Cat() //CONSTRUCTOR
        {
            Console.WriteLine("i am cat constructor, i invoke automatically when cat object is created");
        }
        public override void intro() //METHOD OVERRIDING (RUN TIME POLYMORPHISM| DYNAMIC/LATE BINDING)
        {
            Console.WriteLine(base.type); //base KEYWORD ACCESSING  BASE CLASS FIELD.
            base.intro(); //base KEYWORD ACCESSING BASE CLASS METHOD
            Console.WriteLine("i am a cat");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Cat c1 = new Cat(); //BOTH CAT AND ANIMAL CONSTRUCTOR INVOKES AUTOMATICALLY SINCE CAT INHERITS ANIMAL
            Animal a1 = new Animal(); //ONLY INVOKES ANIMAL CONSTRUCTOR

            c1.intro();
        }
    }
}
