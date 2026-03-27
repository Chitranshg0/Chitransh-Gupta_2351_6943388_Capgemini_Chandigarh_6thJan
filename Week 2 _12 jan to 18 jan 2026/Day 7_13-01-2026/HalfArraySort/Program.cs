namespace HalfArraySort
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Enter array size: ");
            int size = int.Parse(Console.ReadLine());

            int[] arr = new int[size];
            Console.WriteLine("Enter array elements:");
            for (int i = 0; i < size; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            ArraySort obj = new ArraySort();
            int[] result = obj.SortHalf(arr, size);

            Console.WriteLine("Output:");
            foreach (int x in result)
            {
                Console.Write(x + " ");
            }
        }
    }
}
