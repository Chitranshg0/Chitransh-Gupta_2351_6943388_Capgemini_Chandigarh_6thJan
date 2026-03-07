namespace CountingRepeating
{
    internal class Program
    {
        static void Main()
        {
            int[] input1 = { 1, 2, 2, 3, 3 };
            int input2 = 5;
            int input3 = 2;

            SearchBase obj = new SearchDerived();
            int output = obj.CountElement(input1, input2, input3);

            Console.WriteLine("Output=" + output); // Output=2
        }
    }
}
