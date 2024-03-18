using System;

namespace DelegateAsParameter
{
    public delegate void MyDelegate(string msg);

    class ClassA
    {
        public static void MethodA(string message)
        {
            Console.WriteLine("Called ClassA.MethodA() with parameter: " + message);
        }
    }
    class ClassB
    {
        public static void MethodB(string message)
        {
            Console.WriteLine("Called ClassB.MethodB() with parameter: " + message);
        }
    }


    class TestDelegate
    {
        //DELEGATE AS A PARAMETER
        static void InvokeDelegate(MyDelegate myd)
        {
            myd("welcome to .net");
        }
        static void Main(string[] args)
        {
            //DELEGATE OBJECT CREATED WITH TARGETING METHODS
            MyDelegate myd1 = new MyDelegate(ClassA.MethodA); //MyDelegate myd1 = ClassA.MethodA;
            MyDelegate myd2 = new MyDelegate(ClassB.MethodB);

            //INVOKING METHODS USING METHOD WHICH HAS A DELEGATE AS A PARAMETER
            InvokeDelegate(myd1);
            InvokeDelegate(myd2);

            //INVOKING METHODS WITHOUT USING METHOD
            myd1("hello .net");
            myd2("hello .net");

            //myd1 = ClassB.MethodB; //delegate object o
            //InvokeDelegate(myd1);
            

           
        }
    }
}
