using System;

namespace Delegate
{
    // A delegate is a type that represents references to methods with a particular parameter list and return type.
    // When you instantiate a delegate, you can associate its instance with any method with a compatible signature
    // and return type.

    //DECLARING DELEGATE, DELEGATE SIGNATURE = int NumberChanger(int n)
    delegate int NumberChanger(int n);
    class DelegateTest
    {
        static int num = 10;
        //METHOD SIGNATURE MUST  MATCH WITH THE DELEGATE SIGNATURE
        public static int AddNum(int p) //method signature = int AddNum(int p)
        {
            num += p;
            return num;
        }
        public static int MulNum(int q)
        {
            num *= q;
            return num;
        }
        public static int getNum()
        {
            return num;
        }

        static void Main(string[] args)
        {
            //CREATING DELEGATE INSTANCES/OBJECTS AND SETTING A TARGET METHOD
            NumberChanger nc1 = new NumberChanger(AddNum); 
            //NumberChanger nc1 = AddNum; //targeting a method without creating a delegate object
            NumberChanger nc2 = new NumberChanger(MulNum);
            //NumberChanger nc2 = MulNum;


            //CALLING/INVOKING THE METHODS USING DELEGATE OBJECTS
            nc1(5); //OR, nc1.Invoke(5);
            Console.WriteLine("value of Num: {0}", getNum()); //10+5 = 15| new num =15
            nc2(5);
            Console.WriteLine("value of Num: {0}", getNum()); //15*5 = 75
            Console.ReadKey();

        }
    }
}
