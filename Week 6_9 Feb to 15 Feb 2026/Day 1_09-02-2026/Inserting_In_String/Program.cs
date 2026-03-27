namespace Inserting_In_String
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter the string:");
            string input = Console.ReadLine();

            Console.WriteLine("Enter the character to insert:");
            char ch = Console.ReadLine()[0];

            Console.WriteLine("Enter the position:");
            int position = int.Parse(Console.ReadLine());

            string result = input.Insert(position, ch.ToString());
            Console.WriteLine("Result: " + result);
        }
    }
}
