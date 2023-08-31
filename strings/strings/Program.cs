using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;    //Other useful array methods, such as Min, Max, and Sum, can be found in the System.Linq namespace
namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Arrays exercise\n");

            /*strings as array*/
            Console.WriteLine("strings as array");
            string[] random = { "24", "23sd", "phone", "mouse", "keyboard" };
            Console.WriteLine(random[1]); //prtints the 1st array value i.e, '23sd'.

            Console.WriteLine(random[2].Length); //displays the length of 2nd array value i.e, 'phone' which is 5.

            Console.WriteLine(random[4]); //display 4th value; keyboard.
            random[4] = "speaker"; //changes the 4th array value from 'keyboard' to 'speaker'.
            Console.WriteLine(random[4]); //now display the change value i.e, 'speaker' instead of 'keyboard'.

            Console.WriteLine("\n");



            /*Integers as array*/
            Console.WriteLine("*Integers as array");
            int[] ages = { 11, 22, 13, 27, 9, 1 };
            Console.WriteLine(ages[3]);           //prints the 3rd array value i.e, '27'.
            Console.WriteLine(ages.Max());        //prints the max value from array.
            Console.WriteLine(ages.Sum());        //prints the sum value from all array element.
            /*create an array of 5 elements and add values later*/
            string[] ages2 = new string[5];

            /*create an array of 3 elements with value right away*/
            string[] cars = new string[3] { "ferrari", "mercedez", "buggati" };
            Console.WriteLine(cars[0]);

            /*create an array without specifying size with 3 values right away*/
            string[] name = new string[] { "ram", "hari", "sita", "pustam", "anup", "zenish" };
            Console.WriteLine(name[2]);

            Console.WriteLine("\n");



            /*print all values of an array*/
            Console.WriteLine("print all values of an array");
            /*1. using for loop*/
            for (int i = 0; i < name.Length; i++)
            {
                Console.WriteLine(name[i]);
            }

            /*using foreach loop*/
            Array.Sort(name);               //sort string array in alphabetical order.
            foreach (string i in name)
            {
                Console.WriteLine(i);
            }
            Array.Sort(ages);               //sort integer array in ascending order.
            foreach(int i in ages)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("\n");


            /*Multidimensional array*/
            Console.WriteLine("Multidimensional array");
            int[,] twodim = { { 1, 4, 6, 8 }, { 2, 5, 7, 9 } };   //2 dimensional array
            Console.WriteLine(twodim[0,0]);
            Console.WriteLine(twodim[1,3]);

            int[,,] threedim = {{ { 1, 2}, { 3, 4} }, { { 1, 2 }, { 3, 4 } } };  //3 dimensional array
            Console.WriteLine(threedim[0, 1, 1]);
            Console.WriteLine(threedim[1, 1, 1]);
        }

    }
}
