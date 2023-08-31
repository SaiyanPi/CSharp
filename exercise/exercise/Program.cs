internal class Program
{
    private static void Main(string[] args)
    {
        //implicit casting
        int myInt = 5;
        double myDouble = myInt;
        Console.WriteLine(myDouble);
        Console.WriteLine(myInt);
       

        //explicit casting
        double myDouble2 = 5.67;
        int myInt2 = (int)myDouble2;
        Console.WriteLine(myDouble2);
        Console.WriteLine(myInt2);
        

        

       

    }
}