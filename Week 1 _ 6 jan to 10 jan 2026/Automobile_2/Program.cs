namespace Automobile_2
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter the Choice For Selecting : 1 -> Car , 2 -> Bike , 3 -> Airplane");
            int x = int.Parse(Console.ReadLine());

            Vehicle v;

            if (x == 1)
            {
                v = new Car();
            }
            else if (x == 2)
            {
                v = new Bike();
            }
            else if (x == 3)
            {
                v = new Airplane();
            }
            else
            {
                Console.WriteLine("Invalid Choice");
                return;
            }

            v.GetName();
            v.GetSpeed();
            v.GetFuelType();
            v.GetCapacity();
            v.GetModel();

            v.Start();
            v.Accelerate();
            v.Brake();
            v.Stop();
            v.Service();
        }
    }
}
