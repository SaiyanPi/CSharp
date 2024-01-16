using System;
namespace castConvertParse
{
    class Program
    {
        static void Main(string[] args)
        {
            //casting
            Console.WriteLine("1. Casting method :");
            //1. explicit casting(manually| converting larger type to smaller type size: double->float->long->int->char)
            double myDouble = 5.671234567890123;
            int myInt = (int)myDouble;         //cannot implictly convert double to int so we use explicit casting
            float myFloat = (float)myDouble;
            Console.WriteLine(myDouble);
            Console.WriteLine($"explicit parse of '{myDouble}' to an integer is {myInt}");
            Console.WriteLine($"explicit parse of {myDouble} to an float is {myFloat}");

            //2. implicit casting(automatically| converting smaller type to larger type size: char->int->long->float->double)
            int myInt2 = 5;
            double myDouble2 = myInt2;
            Console.WriteLine(myInt2);
            Console.WriteLine($"implicit parse of '{myDouble2}' to a double is {myDouble2}");

            /*3. casting error
            double myDouble3 = 5.67;
            int myInt3 = myDouble3; //cannot cast double to int implicitly, we've to explicitly cast like in no.1
         
            string myString = "1996";
            int myInt4 = (int)myString; //cannot convert type string to int for that we need 'convert' method as follows
            Console.WriteLine(myInt4);
             */
            Console.WriteLine("\n");

            //converting
            Console.WriteLine("2. Conversion method :");

            string myString = "1996";
            int myConvertedData = Convert.ToInt32(myString);
            Console.WriteLine(myString);
            Console.WriteLine($"Conversion of '{myString}' to an integer is {myConvertedData}");

            /* error convert
            string myString2 = "abc";
            int myConvertedData2 = Convert.ToInt32(myString2); //'input string was not in a correct format' because a string can be anything so 
                                                                  inorder to overcome this we use try-catch block
            Console.WriteLine(myString2);
            Console.WriteLine($"Conversion of '{myString2}' to an integer is '{myConvertedData2}'");
            */

            //try_catch
            string myString2 = "abc";
            try
            {
                int myConvertedData2 = Convert.ToInt32(myString2);
                Console.WriteLine($"Conversion of '{myString2}' to an integer is {myConvertedData2}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine("\n");


            //Parsing
            Console.WriteLine("3. Parse method :");

            //parse
            string myString3 = "123";                  //if we give "abc" as a string then the program will crash because we cannot convert string "abc"
                                                       //in integer.
            int parsedString = int.Parse(myString3);
            Console.WriteLine(parsedString);

            //Tryparse
            string myString4 = "abcde";
            int myString4Int;
            int.TryParse(myString4, out myString4Int);  //to overcome the crash we use Tryparse. This returns True or False value based on the
                                                        //success of conversion instead of crashing
            Console.WriteLine(myString4Int);
        }
    }
}
