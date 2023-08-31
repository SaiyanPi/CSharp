

using System;
namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Methods/Functions;
            Note: In C#, it is good practice to start with an uppercase letter when naming methods, as it makes the code easier to read.*/

            SimpleMethod();
            SimpleMethod(); //methods can be called multiple times.

            /*Methods with parameters*/
            ParameterMethod("Neerajan lamsong"); //neerajan is an argument.
            ParameterMethod("Yadu Lamsong");

            /*Multiple parameters*/
            MultiParaMethod(27, "Tinthana"); //the order of the arguments does matter. should be in same order as method (int, string)

            /*Default parameter valuie.*/
            DefaultParameter("Japan"); //argument 'japan' is passed so value of parameter(country) is change into Japan from Nepal.
            DefaultParameter(); //no argument is passed therefore prints default parameter value (Nepal).

            /*Return value*/
            Console.WriteLine(ValRetMethod(1)); //We are only returning value therefore we need writeline
            Console.WriteLine(ValRetMethod2("ACME"));
            Console.WriteLine(ValRetMethod3("Neerajan", "Rai"));
            string fullname = ValRetMethod3("Yadu", "Lamsong"); //We can also store the result in a variable(recommended, as it is easier to read and maintain)
            Console.WriteLine(fullname);

            /*Named arguments*/
            NamedArgMethod(race: "asian", address: "diding", name: "neerajan"); //the order of the arguments does not matter unlike previous arguments
            NamedArgMethod2(age: 26, name: "Neerajan Rai", address: "Diding");  //parameter order in method is (string name, string address, int age)
            Console.WriteLine(NamedArgMethod3(y:4, x:2, z:3));

            /*Method overloading: multiple methods can have the same name with different parameters.
             * Since the method name is similar, the selection of methods depends upon the tye of argument.
             For example if we pass double type argument then the method with double type parameter is selected instead of method with int type parameter*/
            Console.WriteLine(DivMethod(6.5, 3.5));
            int div = DivMethod(15, 3);
            Console.WriteLine("int division result: "+div);
        }






        /*This method does not execute until it is called/refrenced. To execute the method we have to call/reference it*/
        static void SimpleMethod()  //void does not return value.
                                    //static means that the method belongs to the 'class Program' and not an object of the Program class.
                                    //SimpleMethod() is a method name.
        {
            Console.WriteLine("This method has been called.");
        }

        /*Methods with parameters*/
        /*When a parameter is passed to the method, it is called an argument. In following example 'name' is a parameter & 'neerajan...' is an argument.*/
        static void ParameterMethod(string name) //name is a parameter and string is a parameter data type.
        {
            Console.WriteLine(name);
        }

        /*Multiple parameters*/
        static void MultiParaMethod(int age, string address)
        {
            Console.WriteLine("I am "+age+" years old and i live in "+address);
        }

        /*Default parameter value.*/
        static void DefaultParameter(string country = "Nepal") //default parameter value is 'Nepal'.
        {
            Console.WriteLine(country);
        }

        /*Return value*/
        static int ValRetMethod(int id) //we are returning value so no need for void, instead we need a datatype of returning value
        {
            return id;
        }
        static string ValRetMethod2(string school) 
        {
            return "I am a student of " + school;
        }
        static string ValRetMethod3(string name, string surname)
        {
            return name + surname;
        }

        /*Named arguments*/
        static void NamedArgMethod(string name, string address, string race)
        {
            Console.WriteLine("I am " + name + " from " + address + " and i am " + race);
        }
        static void NamedArgMethod2(string name, string address, int age)
        {
            Console.WriteLine("I am " + name + "," + age + " years old from " + address);
        }
        static int NamedArgMethod3(int x, int y, int z)
        {
            return (x + y)/z;
        }

        /*Method overloading: multiple methods can have the same name with different parameters.
         * Multiple methods can have the same name as long as the number and/or type of parameters are different.*/
        static int DivMethod(int x, int y)
        {
            return x / y;
        }
        static double DivMethod(double  x, double y)
        {
            return x / y;
        }
    }
}
