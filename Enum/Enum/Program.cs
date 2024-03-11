/*Enum is a special class that represents the group of constants(unchangable/read-only).
 * To create an enum, use the enum keyword (instead of class or interface), and separate the enum items with a comma: */

using System;
namespace EnumExample
{
    enum Fix //enum outside a class
    {
        low,
        medium,
        high
    }
    class Program
    {
        enum Month //we can also have an enum inside a class:
        {
            janaury, //0
            february, //1
            march, //2
            april,
            may,
            june,
            july,
            august,
            september,
            october,
            november,
            december //11
        }
        public static void Main(string[] args)
        {
            Fix test = Fix.high;
            Console.WriteLine(test);

            Month month = Month.june;
            Console.WriteLine(month);

            int monthNum = (int)Month.june; //to get integer value of an item, we must explicitly convert the item into an int
            Console.WriteLine(monthNum);

            foreach (string s in Enum.GetNames(typeof(Month))) //traversing all values using GetNames()
            {
                Console.WriteLine(s);
            }

            foreach(Fix F in Enum.GetValues(typeof(Fix))) //traversing all values using GetValues()
            {
                Console.WriteLine(F);
            }

        }
    }
   
}
