using System;

namespace ValueReference
{
    class Demo
    {
        public int age = 21;
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Value type behaviour
            int x = 14;
            int y = x;
            Console.WriteLine(x); //14
            Console.WriteLine(y); //14
                       
            y = 15;
            Console.WriteLine(x); //14
            Console.WriteLine(y); //15

            //Reference type behaviour
            Demo obj1 = new Demo();
            Demo obj2 = obj1;
            Console.WriteLine($"obj1.age = {obj1.age} obj2.age = {obj2.age}"); //21

            obj2.age = 27;
            Console.WriteLine($"obj1.age = {obj1.age} obj2.age = {obj2.age}"); //27

            obj1.age = 32;
            Console.WriteLine($"obj1.age = {obj1.age} obj2.age = {obj2.age}"); //32
        }
    }
}

