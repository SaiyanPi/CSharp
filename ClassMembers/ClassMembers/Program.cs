/*create an object of the 'Car' class, with the name 'myObj' and method 'Name'. Then we print the value of the fields 'color' and 'maxSpeed' and method 'CarName'*/
using System;
namespace Mycode
{
    class Car
    {
        /*we can also leave the fields blank, and modify them when creating the object:*/
        String color = "yellow";
        int speed;


        /*Methods*/
        static void CarName(string name)              //static means that the method belongs to the class 'Car' and not an object of the Program class.
        {
            Console.WriteLine(name);
        }
        public void CarCountry(string country)       //public means the method can be accessed publically. object is requirted to access public member
        {
            Console.WriteLine(country);
        }
        static string CarModel(string model)
        {
            return model;
        }



        static void Main(string[] args)
        {
            /*Object 'myObj' created*/
            Car myObj = new Car();

            /*fields modified*/
            myObj.color = "red"; //instead of 'yellow' value is now modified into 'red'.
            myObj.speed = 100;

            /*Methods call*/
            CarName(name: "Lamborghini");    //static means that the method belongs to the class 'Car' and not an object of the class 'Car'. Object is requirted to access public member
            myObj.CarCountry("Nepal");       //Object(myObj) refrence is required for the non-static field

            string carModel = CarModel("Hurricane");
            Console.WriteLine(carModel);

            /*fields call*/
            Console.WriteLine(myObj.color);
            Console.WriteLine(myObj.speed);
            
        }
    }
}