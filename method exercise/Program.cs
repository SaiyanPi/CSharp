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
        static int Method3(int age)
        {
           return age;
        }
        static string Method4(int age, string gender)
        {
            return $"I am a {age} years old {gender}";
        }

        static int MethodOverloading(int x, int y)
        {
            return x + y;
        }
        static double MethodOverloading(double x, double y)
        {
            return x / y;
        }
        static string MethodOverloading(string x, string y)
        {
            return $"This is {x} {y}";
        }
       



        static void Main(string[] args)
        {
            SimpleMethod();
            Method1("Neerajan Rai", 27);
            Method2(wardno: 15, municipality:"chandragiri");
            Console.WriteLine("I am " + Method3(27) + " years old");

            string intro = Method4(gender: "male", age:27);
            Console.WriteLine(intro);

            int calculation1 = MethodOverloading(x: 2, y: 1);
            Console.WriteLine(calculation1);

            double calculation2 = MethodOverloading(x: 4.5, y: 2.5);
            Console.WriteLine(calculation2);

            string statement1 = MethodOverloading(x: "method", y: "overloading");
            Console.WriteLine(statement1);
        }
    }
}