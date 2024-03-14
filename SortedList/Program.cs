using System;
using System.Collections;

namespace Test15_SortedList;
//SortedList<TKey, TValue> is an array of key/value pairs. It stores values on the basis of key.
//Contains unique keys and maintains ascending order on the basis of key.
class Program
{
    static void Main(string[] args)
    {
        //1.
        SortedList sortedList = new SortedList() { { 2, true }, { 1, "one" }, };
        foreach(DictionaryEntry kvp in sortedList)
        {
            Console.Write(kvp.Value); //oneTrue
        }
        Console.WriteLine(Environment.NewLine);

        //2.
        SortedList<int, string> numberName = new SortedList<int, string>() //
        {
            {2, "two"}, //<TKey, TValue>
            { 1, "one" },
            {3, "three" },
            //{2, "four" }, //Run time error, key must be unique
            //{"five", 5 } //Error <int, string>  
        };
        foreach(KeyValuePair<int, string> kvp in numberName)
        {
            Console.WriteLine(kvp.Value+" - "+kvp.Key); //prints "values - key' in ascending order of key i.e, 1,2,3..
        }
        Console.WriteLine(Environment.NewLine);

        //3.
        SortedList<string, string> cityCountry = new SortedList<string, string>()
        {
            {"kathmandu", "nepal"}, //<TKey, TValue>
            {"bangkok", "thailand"},
            {"toronto", "canada"}
        };
        foreach (KeyValuePair<string, string> kvp in cityCountry)
        {
            Console.WriteLine(kvp.Key + " - " + kvp.Value);
        }
        Console.WriteLine(Environment.NewLine);

        //4.
        SortedList<string, int> nameScore = new SortedList<string, int>()
        {
            {"nirajan", 1 }, //<TKey, TValue>
            {"subash",4 },
            {"ramesh", 3 }
        };
        Console.WriteLine("initaial key - values");
        //since number is not a key this time key-values are printed in an alphabetical ascending order i.e, a,b,c,..
        foreach (KeyValuePair<string, int> keyValuePair in nameScore) 
        {
            Console.WriteLine(keyValuePair.Key + " - " + keyValuePair.Value);
        }
        nameScore.Add("bibek", 2); //ADDING NEW KEY-VALUE
        nameScore.Add("sumam", 6);
        nameScore.Add("biswas", 9);
        Console.WriteLine("after adding new key - values");
        foreach(KeyValuePair<string, int> kvp in nameScore)
        {
            Console.WriteLine(kvp.Key+" - "+kvp.Value);
        }




       

    }
}