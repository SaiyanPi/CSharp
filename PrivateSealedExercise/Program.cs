using System;
namespace PrivateSealed
{
    public class PublicClass
    {
        public string sty = "test";
        private class PrivateClass
        {
            private string privatestring = "i am a private field inside a private class";
            public string publicstring = "i am a public field inside a private class";
            public string privateClassMethod( string name, int account)
            {
                return $" {name} : {account}";
            }
        }

        //created a private class object within the containing class to access the field/mewthod of
        //private class later on outside the containing class. It is like a medium through which the 
        //methods outside the private class but within the containing class can have an access to
        //the private class members (fields and methods).
        PrivateClass privateclassobject = new PrivateClass();

        /* privateclassobject.method1(); */ 
        //we cannot directly access the methods/fields of private class through the private class object
     

        //created a public method, this will now access the private class field/method
        //through private class object or "medium" as i've stated in the previous comment.
        public string publicClassMethod1()
        {
            return  privateclassobject.privateClassMethod("Donald Trump", 011169);
        }

        public void publicClassMethod2()
        {
            /* Console.WriteLine(privateclassobject.privatestring); */
            //inaccessible due to its protection level

            Console.WriteLine(privateclassobject.publicstring);
        }

        /*
        public class SubPublicClass : PrivateClass
        {
            private class cannot be inherited or used as a base class for other class.
        }
        */
    }

    public sealed class SealedClass
    {
        public string sentence1 = "i am a string of sealed class";
        public void sealedClassMethod(string message)
        {
            Console.WriteLine(message);
        }
    }

    /*
    public class NormalClass1: SealedClass   
    { 
        sealed class cannot be inherited by other class.
    }
    */


    class Program
    {
        static void Main(string[] args)
        {
            PublicClass publicclassobject = new PublicClass();
            Console.WriteLine(publicclassobject.publicClassMethod1());
            publicclassobject.publicClassMethod2();

            SealedClass sealedclassobject = new SealedClass();
            Console.WriteLine(sealedclassobject.sentence1);
            sealedclassobject.sealedClassMethod("Scope of sealed class is within the namespace");

        }
    }
}
