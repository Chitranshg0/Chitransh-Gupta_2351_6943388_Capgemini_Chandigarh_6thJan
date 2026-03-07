namespace Paalindrome_check
{
    internal class Program
    {
        static void Main()
        {
            string s = Console.ReadLine();
            string rev = new string(s.ToCharArray().Reverse().ToArray());
            Console.WriteLine(s == rev ? "YES" : "NO");
        }
    }
}
