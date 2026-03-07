namespace Vehicle_Rental_System
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Select Vehicle: 1-Car  2-Bike  3-Truck");
            int vChoice = int.Parse(Console.ReadLine());

            Console.Write("Enter Vehicle ID: ");
            int vid = int.Parse(Console.ReadLine());

            Console.Write("Enter Brand: ");
            string brand = Console.ReadLine();

            Console.Write("Enter Rate per Day: ");
            double rate = double.Parse(Console.ReadLine());

            Vehicle vehicle = vChoice switch
            {
                1 => new Car(vid, brand, rate),
                2 => new Bike(vid, brand, rate),
                _ => new Truck(vid, brand, rate)
            };

            Console.Write("Enter Customer ID: ");
            int cid = int.Parse(Console.ReadLine());

            Console.Write("Enter Customer Name: ");
            string cname = Console.ReadLine();

            Customer customer = new Customer(cid, cname);

            Console.Write("Enter Rental Days: ");
            int days = int.Parse(Console.ReadLine());

            RentalTransaction rt = new RentalTransaction(vehicle, customer, days);
            rt.ProcessRental();

            Console.WriteLine("Return Vehicle? (y/n)");
            if (Console.ReadLine().ToLower() == "y")
                rt.ReturnVehicle();

            vehicle.Display();
        }
    }
}
