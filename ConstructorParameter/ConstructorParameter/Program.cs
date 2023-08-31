using System;
namespace ConstructorParameter
{
    class Car
    {
        public string model;
        public int num;

        //class constructor with multiple parameters 'modelName' & 'prodNum'
        public Car(string modelName, int prodNum)
        {
            model = modelName;
            num = prodNum;
        }

        static void Main(string[] args)
        {
            Car Toyota = new Car("Supra", 56);   // Car Toyota = new Car(prodNum:56, modelName:"supra"); 
            //instead of modifying each and every field like below we can simply pass the fiwld value as argument/parameter while creating object as above; hence constructor saves time.
            /*Toyota.model = "Supra";*/
            /*Toyota.num = 56;*/
            Console.WriteLine("Name: " + Toyota.model);
            Console.WriteLine("Production number: " + Toyota.num);


            Phone Samsung = new Phone(purchYear: 2017, phModel: "Galaxy10", phName: "Samsung Galaxy");
            Console.WriteLine(Samsung.name);
            Console.WriteLine(Samsung.model);
            Console.WriteLine(Samsung.year);
        }
    }
}
