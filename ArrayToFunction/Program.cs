using System;
namespace ArrayToFunction
{
    class Program
    {
        //printing array values
        static void method(int[] arra)
        {
            Console.WriteLine("printing array members");
            for(int i = 0; i < arra.Length; i++)
            {
                Console.WriteLine(arra[i]);
            }
        }

        //printing minimun array vallue
        static void minimum(int[] arr)
        {
            int min = arr[0];
            for(int i = 1; i < arr.Length; i++)
            {
                if (min > arr[i])
                {
                    min = arr[i];
                }
            }
            Console.WriteLine($"Minimun value is {min}");
        }

        //printing maximum value
        static void maximum(int[] ar)
        {
            int max = ar[0];
            for (int i = 1; i < ar.Length; i++)
            {
                if (max < ar[i])
                {
                    max = ar[i];
                }
            }
            Console.WriteLine($"Maximum array value is {max}");
        }
        static void Main(string[] args)
        {
            int[] arrayone = { 10, 12, 31, 9 };

            method(arrayone);

            minimum(arrayone);

            maximum(arrayone);
        }
    }
}

 