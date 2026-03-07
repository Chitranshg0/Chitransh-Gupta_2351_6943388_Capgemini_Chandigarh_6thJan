namespace Multiple_5
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter the limit :");
            int input1 = int.Parse(Console.ReadLine());

            IAverage obj = new AvgDivisibleBy5();
            int output = obj.GetAverage(input1);

            Console.WriteLine("OUTPUT -> " + output);
        }
    }
}
