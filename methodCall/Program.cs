using System;
namespace MethodCall;
class Program
{
    //method for call by value
    public void FunctionOne(int x)
    {
        x *= x;
        Console.WriteLine($"value of x inside the first function is {x}");
    }

    //static method
    static void Message()
    {
        Console.WriteLine("This is static method");
    }

    //method for call by reference
    public void Functiontwo(ref int x)
    {
        x *= x;
        Console.WriteLine($"Value inside the second function is {x}");
    }

    //method for out parameter
    static void functionthree(out int y)
    {
        y = 10;
        y *= y;



    }


    static void Main(string[] args)
    {
        int x = 5;
        Program progObject = new Program(); //object created

        //call by value
        Console.WriteLine($"value of x before method call is {x}"); //5
        progObject.FunctionOne(x); //25
        Console.WriteLine($"value of x after function call is {x}"); //5

        Message(); //object reference is not needed for static method.
        
        //Callback by reference
        Console.WriteLine($"value of x before second function call is {x}"); //5
        progObject.Functiontwo(ref x); //25
        Console.WriteLine($"value of x after second function call is {x}"); //25

        //out parameter
        int y = 4;
        Console.WriteLine($"value before passing out y is {y}"); //4
        functionthree(out y);
        Console.WriteLine($"value after passing out y is {y}"); //100
    }
}
