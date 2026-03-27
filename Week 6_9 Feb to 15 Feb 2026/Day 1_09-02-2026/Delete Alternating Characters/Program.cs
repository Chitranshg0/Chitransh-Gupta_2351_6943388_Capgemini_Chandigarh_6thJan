namespace Delete_Alternating_Characters
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter the string:");
            string s = Console.ReadLine();

            string result = "";

            for (int i = 0; i < s.Length; i += 2)
            {
                result += s[i];
            }

            Console.WriteLine("Output: " + result);
        }
    }
}
