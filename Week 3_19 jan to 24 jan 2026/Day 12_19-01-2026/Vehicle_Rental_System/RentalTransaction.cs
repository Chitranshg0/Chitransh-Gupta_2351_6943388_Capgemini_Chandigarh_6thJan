using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicle_Rental_System
{
    internal class RentalTransaction
    {
        public Vehicle Vehicle;
        public Customer Customer;
        public int Days;

        public RentalTransaction(Vehicle v, Customer c, int days)
        {
            Vehicle = v;
            Customer = c;
            Days = days;
        }

        public void ProcessRental()
        {
            Vehicle.Rent();
            double amount = Vehicle.CalculateRent(Days);
            Console.WriteLine($"Rental Amount: {amount}");
        }

        public void ReturnVehicle()
        {
            Vehicle.Return();
            Console.WriteLine("Vehicle Returned Successfully");
        }
    }
}
