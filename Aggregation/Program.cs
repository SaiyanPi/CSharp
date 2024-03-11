using System;
//aggregation is a process in which one class defines another class as any entity reference (way to reuse class)
//it is a form of association that represents HAS-A relationship.
namespace Aggregation
{
    class Address
    {
        public string state, city; //fields
        public Address(string state, string city) //constructor
        { 
            this.state = state;
            this.city = city;
        }
    }

    class Client
    {
        int id;
        string name;
        Address address; //employee HAS-A Address
        public Client(int id, string name, Address address) //put class name(Address) instead of parameter type in a constructor field
        { 
            this.id = id;
            this.name = name;
            this.address = address;
        }
        public void Print() //method
        {
            Console.WriteLine($"CLIENT DETAIL| ID: {id}, NAME: {name}, ADDRESS: {address.state}, {address.city}");
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            Address a1 = new Address("Bagmati", "kathmandu");
            Client c1 = new Client(11, "Roshan", a1); //put Address object as a address parameter
            c1.Print();

        }
    }

}
