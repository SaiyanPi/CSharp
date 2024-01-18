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
            

            //alternatively

            //getting the voting age
            Console.WriteLine("what is the voting age?");
            string x = Console.ReadLine();
            int parsedx;
            int.TryParse(x, out parsedx);
            Console.WriteLine($"Voting age is {parsedx}");

            //getting the person's age
            Console.WriteLine("Enter your age");
            string y = Console.ReadLine();
            int parsedy;
            int.TryParse(y, out parsedy);
            Console.WriteLine($"your age is {parsedy}");

            //comparing and deciding
            if ( parsedy == parsedx || parsedy > parsedx)
            {
                Console.WriteLine("You can vote");
            }
            else 
            { 
                Console.WriteLine("You can't vote."); 
            }
        }
    }
}
