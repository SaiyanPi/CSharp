using System;
namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to simple calculator\n");

            Console.WriteLine("choose the operation you want to perform");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Division");
            Console.WriteLine("4. Multiplication");
            Console.WriteLine("5. Square");
            int operation = Convert.ToInt32(Console.ReadLine());
            switch (operation)
            {
                case 1:
                    Console.WriteLine("Enter the first number: ");
                    double addnum1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter the second number: ");
                    double addnum2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine($"{addnum1}+{addnum2} =" + (addnum1 + addnum2));
                    break;

                case 2:
                    Console.WriteLine("Enter the first number: ");
                    double subnum1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter the second number: ");
                    double subnum2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine($"{subnum1}-{subnum2} =" + (subnum1 - subnum2));
                    break;

                case 3:
                    Console.WriteLine("Enter the first number: ");
                    double divnum1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter the second number: ");
                    double divnum2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine($"{divnum1}/{divnum2} =" + (divnum1 / divnum2));
                    break;

                case 4:
                    Console.WriteLine("Enter the first number: ");
                    double mulnum1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter the second number: ");
                    double mulnum2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine($"{mulnum1}*{mulnum2} =" + (mulnum1 * mulnum2));
                    break;

                case 5:
                    Console.WriteLine("Enter the number: ");
                    double sqnum = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine($"{sqnum}^2 =" + (sqnum * sqnum));
                    break;

            }

            /* Console.WriteLine("Enter a first number");
             double number1 = Convert.ToDouble(Console.ReadLine());


             Console.WriteLine("Enter a second number");
             double number2 = Convert.ToDouble(Console.ReadLine());

             Console.WriteLine("Select the operation you want to perform:");
             Console.WriteLine("1. addition");
             Console.WriteLine("2. subtraction");
             Console.WriteLine("3. division");
             Console.WriteLine("4. multiplication");
             Console.WriteLine("5. square");
             Console.WriteLine("6. square root");
             int operation = Convert.ToInt32(Console.ReadLine());
             switch (operation)
             {
                 case 1:
                     Console.WriteLine($"{number1}+{number2} =" + (number1 + number2));
                     break;
                 case 2:
                     Console.WriteLine($"{number1}-{number2} =" + (number1 - number2));
                     break;
                 case 3:
                     Console.WriteLine($"{number1}/{number2} =" + (number1 / number2));
                     break;
                 case 4:
                     Console.WriteLine($"{number1}*{number2} =" + (number1 * number2));
                     break;
             }*/
        }
    }
}
