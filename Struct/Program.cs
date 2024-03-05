using System;
using System.Reflection.PortableExecutable;
namespace StructClass
{
    //In C#, classes and structs are blueprints that are used to create instance of a class.
    //Structs are used for lightweight objects such as Color, Rectangle, Point etc.
    //Unlike class, structs in C# are value type than reference type.
    //It is useful if you have data that is not intended to be modified after creation of struct.
    public struct Rectangle
    {
        int length, width; //fields
        public Rectangle(int l, int w) //constructor
        {
            this.length = l;
            this.width = w;
        }
        public void areaRectangle() //method
        {
            Console.WriteLine("area of rectangle = "+length*width);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectobject = new Rectangle(5, 3); //object
            rectobject.areaRectangle();

        }
    }
}
