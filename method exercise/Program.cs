using System;
namespace MethodExercise
{
    class Program
    {
        static void SimpleMethod()
        {
            Console.WriteLine("This is a Simple method");
        }
        static void Method1(string name, int age)
        {
            Console.WriteLine($"i am {name} and i am {age} years old");
        }
        static void Method2(string municipality, int wardno)
        {
            Console.WriteLine($"i live in {municipality} {wardno}");
        }







        static void Main(string[] args)
        {
            SimpleMethod();
            Method1("Neerajan Rai", 27);
            Method2(wardno: 15, municipality:"chandragiri");
        }
    }
}