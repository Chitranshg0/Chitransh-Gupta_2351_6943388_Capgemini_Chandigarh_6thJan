using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicle_Rental_System
{
    internal class Truck : Vehicle 
    {
        public Truck(int id, string brand, double rate) : base(id, brand, rate) { }

        public override double CalculateRent(int days)
        {
            return base.CalculateRent(days) + 500; // extra truck charge
        }
    }
}
