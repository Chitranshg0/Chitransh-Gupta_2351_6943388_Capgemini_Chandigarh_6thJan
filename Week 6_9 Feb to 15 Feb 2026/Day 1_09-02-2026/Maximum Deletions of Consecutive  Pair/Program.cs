
namespace Maximum_Deletions_of_Consecutive__Pair
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter the string:");
            string s = Console.ReadLine();

            int deletions = 0;
            int i = 0;

            while (i < s.Length - 1)
            {
                if (s[i] == s[i + 1])
                {
                    deletions++;
                    i += 2;
                }
                else
                {
                    i++;
                }
            }

            Console.WriteLine(deletions);
        }
    }
}
