class Program
{

    public class Vehicle
    {
        public virtual void Drive()
        {
            Console.WriteLine("I am driving a vehicle");
        }
    }

    public class Car : Vehicle
    {
        public override void Drive()
        {
            Console.WriteLine("I am driving a Car");
        }
    }

    public class Toyota : Car
    {
        public override void Drive()
        { 
            Console.WriteLine("I am driving Toyota");            
        }
    }

    static void Main(string[] args)
    {
        Vehicle vechInstance = new Car();
        vechInstance.Drive(); // I am driving a Car.

        Car carInstance = new Toyota();
        carInstance.Drive(); // I am driving a Toyota.

        //Toyota toyotaInstance = new Vehicle(); // error
        //Toyota toyotaInstance = new Car(); // error
    }

}