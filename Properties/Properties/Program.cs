using System;

namespace Properties
{
    /*private variables can only be accessed within the same class (an outside class has no access to it).
     * However, sometimes we need to access them - and it can be done with properties.*/

    class Person
    {
        public string name;
        private string phone = "9803175";

        /*CREATE PROPERTY: It is a good practice to use the same name for both the property and the private field, but with an uppercase first letter.*/
        public string Phone
        {
            get { return phone; }
            set { phone = value; } // this sets the value of private field(phone) to a property(Phone) which can be accessed from other classes.
        }

        public Person(string Pname) //constructor
        {
            name = Pname;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person PerObject = new Person(Pname:"Neerajan Rai");
            Console.WriteLine(PerObject.name);
            /*Console.WriteLine(PerObject.phone); = we cannot field phone since it is private and accessible only to its own class 'Person'*/
            Console.WriteLine(PerObject.Phone); // instead of mentioning private field(phone), simply mention property(Phone) since they both hold the same value.



            Item ItemObject = new Item();
            ItemObject.Name = "Shampo";
            Console.WriteLine(ItemObject.Name);
        }
    }
}
