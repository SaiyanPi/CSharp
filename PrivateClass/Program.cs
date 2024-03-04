using System;
namespace PrivateClass
{
    /* private class PrivateClass
       {
            //error: elements defined in namespace cannot be explicitly declared as a private, protected, .....
       }
    */
    //To create a private class, we need to create private class inside another class
    public class MyPublicClass
    {
        private class MyPrivateClass 
        {
            //accessibility: only accessible within the containing class.
            //inheritance: cannot be inherited or used as a base class for other class.
            //scope: scoped within the containing class.
            //usage: typically used for encapsulating helper classes or functionality that should not be exposed to other classes.
           

        }

        private sealed class MyPrivateSealedClass
        {
            

        }
    }

    public sealed class MySealedClass
    {
        //accessibility: accessible from other class.
        //inheritance: cannot be inherited by other class.
        //scope: scoped within the namespace.
        //usage: typically used to prevent other developers from modifying or extending your code .

    }
    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
