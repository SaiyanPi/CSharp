using System;
using System.Drawing;
namespace Exercise
{
    public static class Circle //static class
    {
        public static float pi = 3.1415f; //static field
        public static float area(int radius) //static method
        {
            return pi * radius * radius ; 
        }
    }

    public class Square //non-static class
    {
        public int area(int length) //non-static method
        {
            return length * length;
        }
    }

    class Rectangle
    {
        private int area1(int length, int width) //private method: only accessible within the class
        {
            return length * width;
        }
        public int area2(int length, int width)
        {
            return length * width;
        }
    }

    class Accessibility
    {
        public string message1 = "i am accessible outside the class";
        private string message2 = "i am not accessible outside the class";
        string message3 = "i am private by default, so not accessible outside the class";
        //private Accessibility() //private constructor
        //{

        //}
    }
    class Program
    {   
        static void Main(string[] args)
        {
            /* Circle a1 = new Circle(); */ //error: cannot create an instance/object of the static class.
            Circle.area(2);
            Console.WriteLine(Circle.area(2));

            /* Square.area(5); */ //error: an object reference is required for a non-static feild, method, or property
            Square squareobject = new Square();
            squareobject.area(4);
            Console.WriteLine(squareobject.area(4));

            Rectangle rectangleobject = new Rectangle();
            /* rectangleobject.area1(4, 5); */ //Rectangle.area() is inaccessible due to its protection level
            rectangleobject.area2(4, 5);
            Console.WriteLine(rectangleobject.area2(4, 5));

            Accessibility accessibilityobject = new Accessibility();
            /* accessibilityobject.message1; */ //error
            Console.WriteLine(accessibilityobject.message1);
            /* Console.WriteLine(accessibilityobject.message2); */ //inaccessible due to protection level.
            /* Console.WriteLine(accessibilityobject.message3); */ //inaccessible due to protection level.
        }
    }
}
