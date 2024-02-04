using System;
namespace ClassConstructorMethodExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Groceries Sunday = new Groceries("Carrot", "2kg", 200); //object created
            Groceries Monday = new Groceries(gamount: "5kg", gname: "potato", gprice: 250);

            Console.WriteLine("name: " + Sunday.name +", "+ Monday.name);
            Console.WriteLine("amount: " + Sunday.amount + ", " + Monday.amount);
            Console.WriteLine("price: " + Sunday.price + ", " + Monday.price);

            Customer Customer1 = new Customer("ram", "kalanki", "1234567890");

            Customer1.TotalCalc();
            
        }
    }
}