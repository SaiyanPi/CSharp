using System;
namespace ifElse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("If else condition \n");


             //asks for a valid voting age
            int votingAge;
            Console.WriteLine("What's the voting age?:");
            do
            {
                int parsedvotingAge;
                if (int.TryParse(Console.ReadLine(), out parsedvotingAge) && parsedvotingAge != 0)
                {
                    votingAge = parsedvotingAge;
                    break;
                }
                else
                {
                    Console.WriteLine("Please enter a valid voting age again: ");
                }
            }
            while (true);


            // asks user for a age and compares the age with voting age to decide if the user can vote or cannot
            Console.WriteLine("Enter Your age: ");
            int parsedAge;
            do
            {
                if (int.TryParse(Console.ReadLine(), out parsedAge) && parsedAge != 0)
                {
                    string message = (parsedAge > votingAge) ? "You can vote." : "You are underage to vote.";
                    Console.WriteLine(message);
                    break;
                }
                else
                {
                    Console.WriteLine("Please enter your valid age again: ");
                }
            }
            while (true);
        }
    }
}
