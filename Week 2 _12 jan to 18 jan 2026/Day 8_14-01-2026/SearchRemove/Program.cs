namespace SearchRemove
{
    internal class Program
    {
        static void Main()
        {
            int[] input1 = { 54, 26, 78, 32, 55 };
            int input2 = 5;
            int input3 = 78;

            ArrayOperation obj = new SearchRemoveSort();
            int[] output = obj.Process(input1, input2, input3);

            foreach (int val in output)
                Console.Write(val + " ");
        }
    }
}
