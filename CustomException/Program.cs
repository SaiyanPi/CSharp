using System;

namespace CustomException
{
    public class InvalidAgeException : Exception //Custom exception need to inherit Exception class
    {
        public InvalidAgeException(string message) : base(message)
        {
           
           
        }
    }

    class TestCustomException
    {
        static void Validate(int age)
        {
            if (age < 18)
            {
                throw new InvalidAgeException("Sorry you are under aged.");
            }

            else
            {
                Console.WriteLine("you can proceed.");
            }
                
        }
        static void Main()
        {
            Console.WriteLine("Enter your age");
            int umer = Convert.ToInt32(Console.ReadLine());
            try
            {
                Validate(umer);
            }
            catch(InvalidAgeException e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
