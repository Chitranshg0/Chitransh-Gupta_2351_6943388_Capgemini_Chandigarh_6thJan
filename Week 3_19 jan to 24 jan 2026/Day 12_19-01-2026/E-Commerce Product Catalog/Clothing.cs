using System;
using System.Collections.Generic;
using System.Text;

namespace E_Commerce_Product_Catalog
{
    internal class Clothing :Product
    {
        public Clothing(int id, string name, double price, int stock)
       : base(id, name, price, stock) { }

        public override string Category() => "Clothing";
    }
}
