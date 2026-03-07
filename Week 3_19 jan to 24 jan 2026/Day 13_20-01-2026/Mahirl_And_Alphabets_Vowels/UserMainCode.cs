using System;
using System.Collections.Generic;
using System.Text;

namespace Mahirl_And_Alphabets_Vowels
{
    internal class UserMainCode
    {
        public static string ProcessString(string s1, string s2)
        {
            StringBuilder filtered = new StringBuilder();

            foreach (char c in s1)
            {
                char ch = char.ToLower(c);

                // check if consonant and present in second string
                if (IsConsonant(ch) && s2.ToLower().Contains(ch))
                    continue;

                filtered.Append(c);
            }

            // remove consecutive duplicates
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < filtered.Length; i++)
            {
                if (i == 0 || filtered[i] != filtered[i - 1])
                    result.Append(filtered[i]);
            }

            return result.ToString();
        }

        static bool IsConsonant(char c)
        {
            return char.IsLetter(c) && !"aeiou".Contains(c);
        }
    }
}
