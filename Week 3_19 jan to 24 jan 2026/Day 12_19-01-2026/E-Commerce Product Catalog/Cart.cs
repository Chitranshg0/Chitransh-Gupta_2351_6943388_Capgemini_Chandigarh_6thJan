using System;
using System.Collections.Generic;
using System.Text;

namespace E_Commerce_Product_Catalog
{
    internal class Cart
    {
        public List<Product> Items = new List<Product>();
        public double TotalAmount;

        public void AddProduct(Product p)
        {
            Items.Add(p);
            TotalAmount += p.GetPrice();
        }

        public void DisplayCart()
        {
            Console.WriteLine("Cart Items:");
            foreach (var p in Items)
                p.Display();

            Console.WriteLine($"Total Amount: {TotalAmount}");
        }
    }
}
