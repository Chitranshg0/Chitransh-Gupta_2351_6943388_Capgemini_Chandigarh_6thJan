namespace SumOfCubeOfPrimes
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Enter the limit: ");
            int input1 = int.Parse(Console.ReadLine());

            PrimeCubeSum obj = new PrimeCubeSum();
            int output = obj.GetSum(input1);

            Console.WriteLine("Output=" + output);
        }
    }
}
