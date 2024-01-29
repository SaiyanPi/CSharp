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
            return x * y;
        }
        static double MethodOverloading(double x, double y)
        {
            return x / y;
        }
        static string MethodOverloading(string x, string y)
        {
            return $"This is {x} {y}";
        }


        //percentage
        //one way: instead of getting arguments from the method as method parameter(like in below multiplication)
        //entire operation like getting argument value
        //calculating percentage value are entirely done inside the method
        static void Percentage()
        {
            Console.WriteLine("Enter the value you want to derive percentage of");
            //int firstval = Convert.ToInt32(Console.ReadLine());
            int firstval;
            Int32.TryParse(Console.ReadLine(), out firstval);
            double firstval1 = firstval;

            Console.WriteLine("Enter the total value you want to derive percentage on");
            //int secondval = Convert.ToInt32(Console.ReadLine());
            int secondval;
            Int32.TryParse(Console.ReadLine(), out secondval);
            double secondval2 = secondval;
           
            double percentage= (firstval1 / secondval2) * 100;
            Console.WriteLine(firstval1 + " out of " + secondval2 + " is = "+percentage+"%");
           
        }

        //multiplication
        //another way: //instead of doing everything inside the method, we only did the calculation this time.
        //gargument value is passed as a method parameter.
        static void Multiplication(int num1, int num2)
        {
            Console.WriteLine(num1 * num2);
        }




        static void Main(string[] args)
        {
            SimpleMethod();
            Method1("Neerajan Rai", 27);
            Method2(wardno: 15, municipality: "chandragiri");
            Console.WriteLine("I am " + Method3(27) + " years old");

            string intro = Method4(gender: "male", age: 27);
            Console.WriteLine(intro);

            int calculation1 = MethodOverloading(x: 1, y: 2);
            Console.WriteLine(calculation1);

            double calculation2 = MethodOverloading(x: 1.0, y: 2.0);
            Console.WriteLine(calculation2);

            string statement1 = MethodOverloading(x: "method", y: "overloading");
            Console.WriteLine(statement1);
            
            //percentage
            Percentage(); //no parameter; entire thing is done inside the method


            //multiplication
            Console.WriteLine("Enter the first number"); //getting argument for method 
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the second number"); //getting argument for method
            int num2 = Convert.ToInt32(Console.ReadLine());

            Multiplication(num1, num2); //argument is passed as a method parmeter
        }
    }
}