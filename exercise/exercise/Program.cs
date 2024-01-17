internal class Program
{
    private static void Main(string[] args)
    {
        //implicit casting: automatically, smaller type to larger type(char->int->long->float->double)
        int myInt = 5;
        double myDouble = myInt;
        Console.WriteLine(myDouble);
        Console.WriteLine(myInt);
       
        char myChar = 'a';
        int myInt1 = myChar;
        Console.WriteLine($"implicit conversion of char '{myChar}' to an integer is '{myInt1}'");


        //explicit casting: manually, larger type to smaller type(double->float->long->int->char)
        double myDouble2 = 5.67;
        int myInt2 = (int)myDouble2;
        Console.WriteLine(myDouble2);
        Console.WriteLine(myInt2);

        double myFloat = 3.1415;
        char myChar1 = (char)myFloat;
        Console.WriteLine($"explicit conversion of double '{myFloat}' to a char is '{myChar1}'");


        //conversion
        string x = "1996";
        int a = Convert.ToInt32(x);
        Console.WriteLine(a);

        string y = "jsidjf";
        try 
        { Console.WriteLine(Convert.ToInt32(y)); } 
        catch 
        { Console.WriteLine("wrong string format"); }

        int myInteger = 36;
        string myString = Convert.ToString(myInteger);
        Console.WriteLine(myString);

        //Parse
        string xy = "1997";
        int ab = int.Parse(xy);
        Console.WriteLine(ab);

        string xyz = "name";
        int abcd;
        int.TryParse(xyz, out abcd);
        Console.WriteLine(abcd); //returns 0 since the given string "name" is in the wrong format for parsing into integer.

        string xyza = "1998";
        int abcde;
        int.TryParse(xyza, out abcde);
        Console.WriteLine(abcde); //returns 1998.
    }
}