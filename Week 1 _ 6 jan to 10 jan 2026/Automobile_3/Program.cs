namespace Automobile_3
{
    enum VehicleType
    {
        Car = 1,
        Bike = 2,
        Airplane = 3
    }

    // INTERFACE
    interface IVehicle
    {
        void Start();
        void Stop();
    }

    // ABSTRACT CLASS
    abstract class Vehicle : IVehicle
    {
        protected string name;
        protected int speed;

        public abstract void Start();
        public abstract void Stop();

        // METHOD OVERLOADING
        public void Display()
        {
            Console.WriteLine("Vehicle Name: " + name);
        }

        public void Display(int speed)
        {
            Console.WriteLine("Vehicle Speed: " + speed);
        }
    }

    // CAR CLASS
    class Car : Vehicle
    {
        public Car()
        {
            name = "Car";
            speed = 120;
        }

        public override void Start()
        {
            Console.WriteLine("Car Started");
        }

        public override void Stop()
        {
            Console.WriteLine("Car Stopped");
        }
    }

    // BIKE CLASS
    class Bike : Vehicle
    {
        public Bike()
        {
            name = "Bike";
            speed = 90;
        }

        public override void Start()
        {
            Console.WriteLine("Bike Started");
        }

        public override void Stop()
        {
            Console.WriteLine("Bike Stopped");
        }
    }

    // AIRPLANE CLASS
    class Airplane : Vehicle
    {
        public Airplane()
        {
            name = "Airplane";
            speed = 800;
        }

        public override void Start()
        {
            Console.WriteLine("Airplane Takeoff");
        }

        public override void Stop()
        {
            Console.WriteLine("Airplane Landed");
        }
    }

    class Program
    {
        // GENERIC FUNCTION
        static void PrintData<T>(T data)
        {
            Console.WriteLine("Generic Output: " + data);
        }

        // THREAD METHOD
        static void ServiceVehicle()
        {
            Console.WriteLine("Servicing Started...");
            Thread.Sleep(2000);
            Console.WriteLine("Servicing Completed");
        }

        static void Main()
        {
            try
            {
                Console.WriteLine("Select Vehicle: 1-Car  2-Bike  3-Airplane");
                int choice = int.Parse(Console.ReadLine());

                Vehicle v;

                // ENUM + POLYMORPHISM
                switch ((VehicleType)choice)
                {
                    case VehicleType.Car:
                        v = new Car();
                        break;
                    case VehicleType.Bike:
                        v = new Bike();
                        break;
                    case VehicleType.Airplane:
                        v = new Airplane();
                        break;
                    default:
                        throw new Exception("Invalid Choice");
                }

                v.Start();
                v.Display();          // Overloading
                v.Display(100);       // Overloading
                v.Stop();

                // GENERIC METHOD CALL
                PrintData<string>("Vehicle Process Completed");

                // MULTI-THREADING
                Thread t1 = new Thread(ServiceVehicle);
                Thread t2 = new Thread(ServiceVehicle);

                t1.Start();
                t2.Start();
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter a valid number");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}