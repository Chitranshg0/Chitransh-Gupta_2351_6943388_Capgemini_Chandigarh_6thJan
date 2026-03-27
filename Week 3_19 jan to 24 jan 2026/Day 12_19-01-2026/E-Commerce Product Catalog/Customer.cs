using System;
using System.Collections.Generic;
using System.Text;

namespace E_Commerce_Product_Catalog
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
