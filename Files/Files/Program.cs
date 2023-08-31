using System;
using System.IO;
namespace Files
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creates a new file and writes the contents to it. If the file already exists, it will be overwritten.
            string Writetext = "This is a file of Neerajan. ";
            File.WriteAllText("Neerajan.txt", Writetext);

            string appendtext = "This is an appended text.";
            File.AppendAllText("Neerajan.txt", appendtext);

            //Reads the content of the file named "Neerajan.txt" 
            string Readtext = File.ReadAllText("Neerajan.txt");
            Console.WriteLine(Readtext);

            //Tests whether the file exists
            string display = (File.Exists("Neerajan.txt")) ? "File exists." : "File does not exist!"; //short hand if-else
            Console.WriteLine(display);

            
        }
    }
}
