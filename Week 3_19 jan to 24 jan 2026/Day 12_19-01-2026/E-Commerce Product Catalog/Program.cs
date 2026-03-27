namespace E_Commerce_Product_Catalog
{
    internal class Program
    {
        static void Main()
        {
            List<Product> products = new List<Product>();

            Console.WriteLine("Add Product");
            Console.WriteLine("1-Electronics  2-Clothing  3-Books");
            int choice = int.Parse(Console.ReadLine());

            Console.Write("Product ID: ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Price: ");
            double price = double.Parse(Console.ReadLine());

            Console.Write("Stock: ");
            int stock = int.Parse(Console.ReadLine());

            Product p = choice switch
            {
                1 => new Electronics(id, name, price, stock),
                2 => new Clothing(id, name, price, stock),
                _ => new Books(id, name, price, stock)
            };

            products.Add(p);

            Console.WriteLine("\nProduct List:");
            foreach (var prod in products)
                prod.Display();

            Console.Write("\nEnter Customer ID: ");
            int cid = int.Parse(Console.ReadLine());

            Console.Write("Enter Customer Name: ");
            string cname = Console.ReadLine();

            Customer customer = new Customer(cid, cname);
            Cart cart = new Cart();

            Console.Write("Add product to cart? (y/n): ");
            if (Console.ReadLine().ToLower() == "y")
            {
                Console.Write("Enter Quantity: ");
                int qty = int.Parse(Console.ReadLine());

                if (p.ReduceStock(qty))
                {
                    for (int i = 0; i < qty; i++)
                        cart.AddProduct(p);
                }
                else
                {
                    Console.WriteLine("Insufficient Stock");
                }
            }

            Order order = new Order(customer, cart);
            order.PlaceOrder();
        }
    }
}
