using System;
namespace AutomaticPropertry
{
    /*C# also provides a way to use short-hand / automatic properties, where you do not have to define the field for the property,
     * and you only have to write get; and set; inside the property.*/
    class Person
    {
/*      private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }*/
        /*Instead of writing above codes just need to write following code hence less code*/
        public string Name { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person PersonObject = new Person();
            PersonObject.Name = "Big da";

            Console.WriteLine(PersonObject.Name);

        }
    }
}
