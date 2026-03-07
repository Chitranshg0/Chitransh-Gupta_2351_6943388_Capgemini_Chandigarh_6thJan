namespace Longest_Substring
{
    internal class Program
    {
        static void Main()
        {
            string s = Console.ReadLine();
            HashSet<char> set = new HashSet<char>();
            int left = 0, maxLen = 0;

            for (int right = 0; right < s.Length; right++)
            {
                while (set.Contains(s[right]))
                    set.Remove(s[left++]);

                set.Add(s[right]);
                maxLen = Math.Max(maxLen, right - left + 1);
            }
            Console.WriteLine(maxLen);
        }
    }
}
