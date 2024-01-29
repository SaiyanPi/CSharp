using System;
using System.Text.RegularExpressions;

namespace Constructor
{
    class Phone
    {
        //create a field 'model'
        public string model;
        string year;
        // Create a class constructor for the Phone class
        //the constructor name must match the class name, and it cannot have a return type(like void or int).
        //All classes have constructors by default: if you do not create a class constructor yourself, C# creates one for you.
        //However, then you are not able to set initial values for fields.
        public Phone()
        {
            model = "iphone11";  //Set the initial value for field 'model'
            year = "2019";
        }

        static void Main(string[] args)
        {
            //Create an object 'Apple'
            //the constructor is called when the object is created.
            Phone Apple = new Phone(); 
            Console.WriteLine(Apple.model);  //Print the value of model
            Console.WriteLine(Apple.year);

        }
    }
}
