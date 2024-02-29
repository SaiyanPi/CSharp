using System;
namespace StaticClass
{
    static class MyMath //static class
    {
        //static class only contains static members
        public static float Pi = 3.14f; //static field
        public static int square(int x) //static method
        {
            return x * x;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //static members are accessed outside the static class with the name of the static class
            Console.WriteLine($"value of pi is: {MyMath.Pi}");
            Console.WriteLine($"square of 6 is: {MyMath.square(6)}");
        }
    }
}