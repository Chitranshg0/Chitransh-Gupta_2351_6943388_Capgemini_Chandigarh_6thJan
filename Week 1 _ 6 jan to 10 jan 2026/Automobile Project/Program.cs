namespace Automobile_Project
{
    internal class Program
    {
        static void Main()
        {
            Vehicle v;

            Console.WriteLine("1. Car");
            Console.WriteLine("2. Bike");
            Console.WriteLine("3. Airplane");
            Console.Write("Enter your choice: ");
            int choice = int.Parse(Console.ReadLine());

            if (choice == 1)
                v = new Car();
            else if (choice == 2)
                v = new Bike();
            else if (choice == 3)
                v = new Airplane();
            else
            {
                Console.WriteLine("Invalid choice");
                return;
            }

            v.GetInput();     
            v.ShowOutput();    
        }
    }
}
