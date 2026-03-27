using System;
using System.Collections.Generic;
using System.Text;

namespace E_Commerce_Product_Catalog
{
    internal class Order
    {
        public Customer Customer;
        public Cart Cart;

        public Order(Customer c, Cart cart)
        {
            Customer = c;
            Cart = cart;
        }

        public void PlaceOrder()
        {
            Console.WriteLine($"Order placed by {Customer.Name}");
            Cart.DisplayCart();
        }
    }
}
