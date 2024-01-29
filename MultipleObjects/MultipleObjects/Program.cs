using System;
namespace MyCode
{
    class MultipleObjects
    {
        string name = "abcd"; //field or attribute(variable declared directly inside class)
        int age = 27;
        static void Main(string[] args)
        {
            MultipleObjects obj1 = new MultipleObjects();
            MultipleObjects obj2 = new MultipleObjects();

            Console.WriteLine(obj1.name);
            Console.WriteLine(obj2.name);
            Console.WriteLine(obj1.age);

            //Class1 obj3 = new Class1();
            //Console.WriteLine(Obj3.message);
        }
    }
}
