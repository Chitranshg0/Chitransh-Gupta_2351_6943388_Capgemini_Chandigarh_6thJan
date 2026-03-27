namespace SearchElement
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

            Console.Write("Enter element to search: ");
            int key = int.Parse(Console.ReadLine());

            ArraySearch obj = new ArraySearch();
            int output = obj.Search(arr, size, key);

            Console.WriteLine("Output=" + output);
        }
    }
}
