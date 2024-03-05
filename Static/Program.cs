using System;
namespace Static
{
    class Account
    {
        public string type = "savings";
        public int id;
        public string name;
        public static float interest = 5.5f; //static field
           //static field - is used to refer common property of all objects such as interest rate. 
           //static means that it belongs to the 'class Account' and not an object of the Account.


        public Account(int id, string name) //constructor
        {
            this.id = id;
            this.name = name;

        }

        public void display() //method
        {
            Console.WriteLine($"id: {id}, name: {name}, interest rate: {interest}");
        }

        public static void staticDisplay(string accountType)
        {
            Console.WriteLine($"account type: {accountType}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account(24, "bobby"); //object
            account.display();
            Console.WriteLine(account.type); //we can access non-static field
            /* Console.WriteLine(account.interest);
            account.staticDisplay("savings"); */
                                             //cannot access static field 'interest' because static field only belongs to its class Account
                                             //and not to an object of the Account

            
        }
    }
}