namespace Multiple_5
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter the size");
            int input2 = int.Parse(Console.ReadLine());
            int[] input1 = new int[input2];
            Console.WriteLine("Enter the elements");
            for (int i = 0; i < input2; i++)
                input1[i] = int.Parse(Console.ReadLine());
            Console.WriteLine("Output");
            Multiple obj = new Multiple();
            int output = obj.FindAverage(input1, input2);
            Console.WriteLine(output);
        }
    }
}
