namespace Anagram_Check
{
    internal class Program
    {
        static void Main()
        {
            string s1 = Console.ReadLine();
            string s2 = Console.ReadLine();

            char[] a = s1.ToCharArray();
            char[] b = s2.ToCharArray();
            Array.Sort(a);
            Array.Sort(b);

            Console.WriteLine(new string(a) == new string(b) ? "YES" : "NO");
        }
    }
}
