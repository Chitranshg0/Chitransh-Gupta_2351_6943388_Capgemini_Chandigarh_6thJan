namespace PrimeCubeSum
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter the no.");
            int n = int.Parse(Console.ReadLine());
            PrimeSum obj = new PrimeSum();
            int output = obj.FindSum(n);
            Console.WriteLine("Output -> " + output);
        }
    }
}
