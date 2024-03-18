using System;
using System.Collections.Generic;

namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = new List<string>(); //CREATE A LIST OF STRINGS
            names.Add("abhisek"); //ADDING STRING VALUES IN LIST
            names.Add("pustam");

            var ages = new List<int>() { 23, 17, 32, 29}; //LIST OF INT USING COLLECTION INITIALIZER


            foreach(var name in names)
            {
                Console.WriteLine(name);
            }
            foreach(var age in ages)
            {
                Console.WriteLine(age);
            }
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
