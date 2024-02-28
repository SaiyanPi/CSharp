using System;
namespace MethodCall;
class Program
{
    
    public void FunctionOne(int x)
    {
        x *= x;
        Console.WriteLine($"value of x inside the first function is {x}");
    }

    static void Message()
    {
        Console.WriteLine("This is static method");
    }

    public void Functiontwo(ref int x)
    {
        x *= x;
        Console.WriteLine($"Value inside the second function is {x}");
    }


    static void Main(string[] args)
    {
        int x = 5;
        Program progObject = new Program();

        Console.WriteLine($"value of x before method call is {x}");
        progObject.FunctionOne(x);
        Console.WriteLine($"value of x after function call is {x}");

        Message(); //object reference is not needed for static method.
        
        Console.WriteLine($"value of x before second function call is {x}");
        progObject.Functiontwo(ref x);
        Console.WriteLine($"value of x after second function call is {x}");
    }
}
