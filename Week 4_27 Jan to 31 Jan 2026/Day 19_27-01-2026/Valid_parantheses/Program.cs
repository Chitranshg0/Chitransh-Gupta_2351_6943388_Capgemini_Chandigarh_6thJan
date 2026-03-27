namespace Valid_parantheses
{
    internal class Program
    {
        static void Main()
        {
            string s = Console.ReadLine();
            Stack<char> st = new Stack<char>();

            foreach (char c in s)
            {
                if (c == '(' || c == '{' || c == '[')
                    st.Push(c);
                else
                {
                    if (st.Count == 0) { Console.WriteLine("NO"); return; }
                    char top = st.Pop();
                    if ((c == ')' && top != '(') ||
                        (c == '}' && top != '{') ||
                        (c == ']' && top != '['))
                    {
                        Console.WriteLine("NO");
                        return;
                    }
                }
            }
            Console.WriteLine(st.Count == 0 ? "YES" : "NO");
        }
    }
}
