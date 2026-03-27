namespace auto
{
   
        // ENUM
        enum VehicleType
        {
            Car = 1,
            Bike = 2,
            Airplane = 3
        }

        // INTERFACE
        interface IVehicle
        {
            string Name { get; }
            decimal Price { get; }
            void Display();
        }

        // ABSTRACT CLASS
        abstract class Vehicle : IVehicle
        {
            public string Name { get; protected set; }
            public decimal Price { get; protected set; }

            public abstract void Display();
        }

        // CAR
        class Car : Vehicle
        {
            public Car(string name, decimal price)
            {
                Name = name;
                Price = price;
            }

            public override void Display()
            {
                Console.WriteLine($"Car: {Name} | Price: {Price}");
            }
        }

        // BIKE
        class Bike : Vehicle
        {
            public Bike(string name, decimal price)
            {
                Name = name;
                Price = price;
            }

            public override void Display()
            {
                Console.WriteLine($"Bike: {Name} | Price: {Price}");
            }
        }

        // AIRPLANE
        class Airplane : Vehicle
        {
            public Airplane(string name, decimal price)
            {
                Name = name;
                Price = price;
            }

            public override void Display()
            {
                Console.WriteLine($"Airplane: {Name} | Price: ₹{Price}");
            }
        }

        class Program
        {
            static void Main()
            {
                List<Vehicle> cart = new List<Vehicle>();
                bool exit = false;

                while (!exit)
                {
                    Console.WriteLine("\n1.Car  2.Bike  3.Airplane  4.View Cart  5.Exit");
                    Console.Write("Enter choice: ");
                    int choice = int.Parse(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("1. Sedan 10,00,000\n2. SUV 15,00,000");
                            int c = int.Parse(Console.ReadLine());
                            if (c == 1)
                                cart.Add(new Car("Sedan", 1000000));
                            else
                                cart.Add(new Car("SUV", 1500000));
                            Console.WriteLine("Car added to cart");
                            break;

                        case 2:
                            Console.WriteLine("1. Sports Bike 1,50,000\n2. Cruiser 2,00,000");
                            int b = int.Parse(Console.ReadLine());
                            if (b == 1)
                                cart.Add(new Bike("Sports Bike", 150000));
                            else
                                cart.Add(new Bike("Cruiser", 200000));
                            Console.WriteLine("Bike added to cart");
                            break;

                        case 3:
                            Console.WriteLine("1. Private Jet 5,00,00,000\n2. Commercial Plane 50,00,00,000");
                            int a = int.Parse(Console.ReadLine());
                            if (a == 1)
                                cart.Add(new Airplane("Private Jet", 50000000));
                            else
                                cart.Add(new Airplane("Commercial Plane", 500000000));
                            Console.WriteLine("Airplane added to cart");
                            break;

                        case 4:
                            decimal total = 0;
                            Console.WriteLine("\n--- CART DETAILS ---");
                            foreach (var v in cart)
                            {
                                v.Display();
                                total += v.Price;
                            }
                            Console.WriteLine($"Total Items: {cart.Count}");
                            Console.WriteLine($"Total Amount: {total}");
                            break;

                        case 5:
                            exit = true;
                            Console.WriteLine("Thank you for shopping!");
                            break;

                        default:
                            Console.WriteLine("Invalid choice");
                            break;
                    }

                    Thread.Sleep(500); // Thread usage
                }
            }
        }
    }

