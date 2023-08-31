using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifier
{
    //public access modifier, it is accessible for all classes
    public class Course
    {
        public string name;  //field 'Name'can be accessible for all class
        public string description;
        private int period;  //field 'period'can be accessed only within the class 'Course'.

        public Course(string CourseName, string CourseDiscp, int CoursePeriod)
        {
            name = CourseName;
            description = CourseDiscp;
            period = CoursePeriod;
        }

        /*static void Main(string[] args)
        {
            Course LocalObject = new Course(CourseName:"GK", CourseDiscp:"you'll learn about general knowledge.", CoursePeriod:1);
            Console.WriteLine(LocalObject.name);
            Console.WriteLine(LocalObject.description);
            Console.WriteLine(LocalObject.period);

        }*/
    }
}
