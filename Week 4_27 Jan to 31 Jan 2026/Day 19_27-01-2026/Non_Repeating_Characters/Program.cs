namespace Non_Repeating_Characters
{
    internal class Program
    {
        static void Main()
        {
            string s = Console.ReadLine();
            Dictionary<char, int> map = new Dictionary<char, int>();

            foreach (char c in s)
                map[c] = map.ContainsKey(c) ? map[c] + 1 : 1;

            foreach (char c in s)
            {
                if (map[c] == 1)
                {
                    Console.WriteLine(c);
                    return;
                }
            }
            Console.WriteLine("-1");
        }
    }
}
