using System;
namespace Class
{
    /*it is common that the name of the C# file and the class matches, as it makes our code organized.
     * it is common that the name of the C# file and the class matches, as it makes our code organized.*/
    class Phone 
    {
        string phname = "redmi"; //When a variable is declared directly in a class, it is often referred to as a field (or attribute).

        int phprice = 27000;
        static void Main(string[] args)
        {
            /*To create an object of Car, specify the class name, followed by the object name, and use the keyword new.
             * Here 'myObject' is an object of class 'Phone'*/
            Phone myObject = new Phone(); // or jus a 'Phone myObject2 = new();'
            Console.WriteLine(myObject.phname); //we use the dot syntax (.) to access variables/fields(phname) inside a class(Phone)

            Console.WriteLine(myObject.phprice);

        }
    }
}
