namespace Next_Constant_or_vowel
{
    internal class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string result = UserProgramCode.nextString(input);
            Console.WriteLine(result);
        }
    }

    class UserProgramCode
    {
        public static string nextString(string input1)
        {
            string vowels = "aeiouAEIOU";
            string result = "";

            foreach (char c in input1)
            {
                if (!char.IsLetter(c))
                    return "Invalid input";

                if (vowels.Contains(c))
                {
                    result += getNextConsonant(c);
                }
                else
                {
                    result += getNextVowel(c);
                }
            }
            return result;
        }

        static char getNextConsonant(char c)
        {
            char ch = c;
            do
            {
                ch = (ch == 'z') ? 'b' :
                     (ch == 'Z') ? 'B' :
                     (char)(ch + 1);
            } while ("aeiouAEIOU".Contains(ch));
            return ch;
        }

        static char getNextVowel(char c)
        {
            char[] v = char.IsUpper(c)
                ? new char[] { 'A', 'E', 'I', 'O', 'U' }
                : new char[] { 'a', 'e', 'i', 'o', 'u' };

            foreach (char x in v)
                if (x > c) return x;

            return v[0];
        }
    }
}
