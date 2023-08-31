using MultipleClass;
using System;
namespace MultipleClasss
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Object created*/
            Car Toyota = new Car();
            /*fields modified*/
            Toyota.name = "Prius";
            Toyota.color = "Silver";
            Toyota.topspeed = 200;

            Car Lamborghini = new Car();
            Lamborghini.name = "Aventador";
            Lamborghini.color = "Red";
            Lamborghini.topspeed = 250;

            Console.WriteLine(Toyota.name +":"+ Toyota.color);
            Toyota.Country(country: "Nepal", zipcode: 44600);
            Console.WriteLine(Toyota.Person(pname: "Neerajan Rai", address: "Kathmandu"));
            Toyota.PurchasedYear(2025);

            Console.WriteLine(Lamborghini.name + ":" + Lamborghini.color);
            Lamborghini.Country(country: "Nepal", zipcode: 55600);
            Console.WriteLine(Lamborghini.Person(pname: "Neerajan Rai", address: "Ithari"));
            Lamborghini.PurchasedYear(year: 2035);
        }
    }
}
