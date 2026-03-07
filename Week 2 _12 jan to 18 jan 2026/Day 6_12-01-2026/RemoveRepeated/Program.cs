using RemoveRepeated;
namespace RemoveRepeated
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter the size");
            int size = int.Parse(Console.ReadLine());
            int[] input = new int[size];
            Console.WriteLine("Enter the Elements");
            for (int i = 0; i < size; i++)
                input[i] = int.Parse(Console.ReadLine());

            Remove obj = new Remove();
            int[] output = obj.RemoveDuplicates(input, size);
            Console.WriteLine("Output array");
            for (int i = 0; i < output.Length; i++)
                Console.Write(output[i] + " ");
        }
    }
}
