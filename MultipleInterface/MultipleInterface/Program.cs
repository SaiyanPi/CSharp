using System;
namespace MultipleInterface
{
    interface IfirstInterface //interface 1
    {
        void firstMethod();//method of interface 1
    }
    interface IsecondInterface //interface 2
    {
        void secondMethod(); //method of interface 2
    }
    class Abc:IfirstInterface, IsecondInterface //multiple interface
    {
        public void firstMethod() //body of method of inetrface 1
        {
            Console.WriteLine("I am first interface method");
        }

        public void secondMethod()//body of method of interface 2
        {
            Console.WriteLine("I am second interface method");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Abc abcObject = new Abc(); //object of Abc
            abcObject.firstMethod(); //accessing interface method through class Abc's object.
            abcObject.secondMethod();
        }
    }
}
