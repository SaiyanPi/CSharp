using System;
using System.Net.NetworkInformation;

namespace EXception
{
    class Program
    {
        static void Main(string[] args)
        {
            try //The try statement allows you to define a block of code to be tested for errors while it is being executed.
            {
                int[] number = { 1, 2, 3, 4, 5, 6, };
                Console.WriteLine(number[6]); //number[6] does not exist.
            }
            catch (Exception abc) //The catch statement allows you to define a block of code to be executed, if an error occurs in the try block.
            {
                Console.WriteLine(abc.Message); //built-in Message property
            }


            try
            {
                string[] pustam= { "big", "famous", "coldstore", "godam" };
                Console.WriteLine(pustam[5]);
            }
            catch (Exception e)
            {
                Console.WriteLine("pustam does not have that name"); //custom error message
            }
            finally //The finally statement lets you execute code, after try...catch, regardless of the result
            {
                Console.WriteLine("finally the try-catch is finished");
            }
        }
    }
}
