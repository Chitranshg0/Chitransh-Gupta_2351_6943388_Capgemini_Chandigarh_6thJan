using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicle_Rental_System
{
    internal class Customer
    {
        public int CustomerId;
        public string Name;

        public Customer(int id, string name)
        {
            CustomerId = id;
            Name = name;
        }
    }
}
