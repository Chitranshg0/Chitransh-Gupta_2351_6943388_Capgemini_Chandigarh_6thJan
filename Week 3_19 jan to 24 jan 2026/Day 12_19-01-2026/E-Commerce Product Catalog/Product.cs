using System;
using System.Collections.Generic;
using System.Text;

namespace E_Commerce_Product_Catalog
{
    internal class Product
    {
        private int productId;
        private string name;
        protected double price;
        protected int stock;

        public Product(int id, string name, double price, int stock)
        {
            productId = id;
            this.name = name;
            this.price = price;
            this.stock = stock;
        }

        public int ProductId => productId;
        public string Name => name;

        public virtual string Category() => "General";

        public virtual void Display()
        {
            Console.WriteLine($"ID:{productId} Name:{name} Category:{Category()} Price:{price} Stock:{stock}");
        }

        public bool ReduceStock(int qty)
        {
            if (qty <= stock)
            {
                stock -= qty;
                return true;
            }
            return false;
        }

        public double GetPrice() => price;
    }
}
