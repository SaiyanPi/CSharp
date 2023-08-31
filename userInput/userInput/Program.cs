    using System;
using System.Diagnostics;

namespace userInput
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your username: ");
            do
            {
                string username = Console.ReadLine();
                if (String.IsNullOrEmpty(username))
                {
                    Console.WriteLine("Username can't be empty! please Enter your username: ");
                }
                else
                {
                    Console.WriteLine($"Welcome {username}");
                    break;
                }
            }
            while (true);


            Console.WriteLine("Enter your age: ");
            do
            {
                int parsedAge;
                if (int.TryParse(Console.ReadLine(), out parsedAge) && parsedAge != 0)   
 /* age(string) is parsed here into integer: so when user inputs null value and characters as age it returns false and asks for input again 
  * until the user inputs number and breaks but also from the second Condition it doesn't accept 0 as age because age cannot be 0. so only when the age is 
  * not null or characters and 0 it returns true and executes the line */
                {
                    Console.WriteLine($"Your age is {parsedAge}");
                    break;
                }
                else
                {
                    Console.WriteLine($"Please enter your valid age again: ");
                }
            }
            while (true);


            Console.WriteLine("Enter your address: ");
            do
            {
                string address = Console.ReadLine();
                if (String.IsNullOrEmpty(address))
                {
                    Console.WriteLine("Address can't be empty! please enter your address: ");
                }
                else
                {
                    Console.WriteLine($"Your address is {address}");
                    break;
                }
            }
            while (true);
        }

    }
}