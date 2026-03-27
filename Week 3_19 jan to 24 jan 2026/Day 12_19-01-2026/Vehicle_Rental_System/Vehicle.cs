using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicle_Rental_System
{
    internal class Vehicle
    {
        protected int vehicleId;
        protected string brand;
        protected double ratePerDay;
        protected bool isRented;

        public Vehicle(int id, string brand, double rate)
        {
            vehicleId = id;
            this.brand = brand;
            ratePerDay = rate;
            isRented = false;
        }

        public virtual double CalculateRent(int days)
        {
            return ratePerDay * days;
        }

        public void Rent()
        {
            isRented = true;
        }

        public void Return()
        {
            isRented = false;
        }

        public virtual void Display()
        {
            Console.WriteLine($"ID:{vehicleId} Brand:{brand} Rate/Day:{ratePerDay} Rented:{isRented}");
        }
    }
}
