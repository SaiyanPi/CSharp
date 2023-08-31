using System;
namespace AccessModifier
{
    /*Access modifier helps to achieve "Encapsulation" - which is the process of making sure that "sensitive" data is hidden from users.This is done by declaring fields as private.*/
    /*Note: By default, all members of a class are private if you don't specify an access modifier:*/
    class Demo
    {
        private string message1 = "i am not accessibl"; //only accessible within the class.
        public string message2 = "i am accessible because my access modifier is public"; //can be accessed outside the class.
        string message3 = "i am private by default";   //private by default.
    }
    class Program
    {
        private string language;   //can be accessed only within the class 'Program'
        private string application;

        private Program(string pLanguage, string pApplication)
        {
            language = pLanguage;
            application = pApplication;
        }
        static void Main(string[] args)
        {
            Program Object = new Program("C#", "Game");
            Console.WriteLine(Object.language);
            Console.WriteLine(Object.application);

            Demo demoObj = new Demo();
           /* Console.WriteLine(demoObj.message1);*/ 
            Console.WriteLine(demoObj.message2);

            Course Object2 = new Course(CourseName: "Coding", CourseDiscp: "You'll learn to code", CoursePeriod: 1);
            Console.WriteLine(Object2.name);
            Console.WriteLine(Object2.description);
            // Console.WriteLine(Object2.period);

        }
    }
}


