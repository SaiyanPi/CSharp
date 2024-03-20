using System;
using System.Collections.Generic;

//List: LIST OF STRONGLY TYPED OBJETCS, UNORDERED, ALLOWS DUPLICATION
namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>(); //CREATE A LIST OF STRINGS
            //var names = new List<string>(); //alternate of the previous line9declaring list)

            //INSERTING
            names.Add("abhisek"); //ADDING STRING VALUES IN LIST (O INDEX)
            names.Add("pustam"); //1 INDEX
            names.Insert(1, "sajan"); //INSERTING NEW OBJECT TO A POSITION 1
            string[] fellas = { "roshan", "roshik", "nischal" };
            names.InsertRange(0, fellas); //INSERTING A COLLECTION OF OBJECTS(string array) IN A LIST IN INDEX 0
            
            //REMOVING
            names.Remove("abhisek"); //DIRECTLY MENTIONING OBJECT
            names.RemoveAt(2); //BY MENTIONING INDEX NUMBER
            names.RemoveRange(0, 2); //BY MENTIONING INDEX RANGE
            names.Clear(); //REMOVES ALL ITEM/OBJECTS

            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine(Environment.NewLine);

            //CHECK IF AN ITEM EXISTS
            var ages = new List<int>() { 23, 29, 17, 32, 29, 19}; //LIST OF INT USING COLLECTION INITIALIZER
            Console.WriteLine("Count = " + ages.Count); //5
            int id = ages.IndexOf(29); //returns -1 if no items are located in the list
            if (id > 0)
            {
                Console.WriteLine($"Item index in the list is {id}");
            }
            else
            {
                Console.WriteLine("Item not found");
            }
            Console.WriteLine(ages.IndexOf(17, 3)); // -1 because 17 is in the 2nd index position

            //SORT A LIST
            ages.Sort(); //SORTS ALL ITEM OF THE LIST
            foreach(int age in ages)
            {
                Console.WriteLine(age);
            }
            Console.WriteLine(Environment.NewLine);

            //FIND AN ITEM IN A SORTED LIST
            int bs = ages.BinarySearch(32); //ages must be sorted 
            Console.WriteLine("Index of 32 in the sorted list is " + bs); //5
            Console.WriteLine(Environment.NewLine); 

            //REVERSE A LIST
            ages.Reverse(); //REVERSE ALL ITEM OF LIST
            foreach (int age in ages)
            {
                Console.WriteLine(age);
            }
            Console.WriteLine(Environment.NewLine);

            //CONVERT LIST TO AN ARRAY
            int[] agesArray = ages.ToArray();
            Console.WriteLine(Environment.NewLine);


            var courses = new List<string>();           
            //for (; ; ) //INFINITE LOOP
            //{
            //    Console.Write("Enter your course name : ");
            //    courses.Add(Console.ReadLine());

            //    Console.WriteLine("List of courses:");
            //    foreach (var course in courses)
            //    {
            //        Console.WriteLine(course);
            //    }
            //}

            while (true) //INFINITE LOOP
            {
                do
                {
                    Console.Write("Enter your course name : ");
                    string userEntry = Console.ReadLine();
                    if (string.IsNullOrEmpty(userEntry))
                    {
                        Console.WriteLine("course can't be empty, please enter again");
                    }
                    else
                    {
                        courses.Add(userEntry);
                        break;
                    }
                }
                while (true);

                Console.WriteLine(Environment.NewLine);
                Console.WriteLine("List of courses:");
                foreach (var course in courses)
                {
                    Console.WriteLine(course);
                }

            }
            




        }
    }
}
