namespace String_Compression
{
    internal class Program
    {
        static void Main()
        {
            string s = Console.ReadLine();
            string result = "";
            int count = 1;

            for (int i = 1; i <= s.Length; i++)
            {
                if (i < s.Length && s[i] == s[i - 1])
                    count++;
                else
                {
                    result += s[i - 1] + count.ToString();
                    count = 1;
                }
            }
            Console.WriteLine(result);
        }
    }
}
