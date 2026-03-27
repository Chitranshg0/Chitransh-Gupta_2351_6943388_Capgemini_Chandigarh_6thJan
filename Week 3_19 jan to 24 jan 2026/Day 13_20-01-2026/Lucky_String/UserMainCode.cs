using System;
using System.Collections.Generic;
using System.Text;

namespace Lucky_String
{
    internal class UserMainCode
    {
        public static string CheckLuckyString(int n, string str)
        {
            if (n > str.Length)
                return "Invalid";

            for (int i = 0; i <= str.Length - n; i++)
            {
                string sub = str.Substring(i, n);

                // check only P, S, G
                bool validChars = true;
                foreach (char c in sub)
                {
                    if (c != 'P' && c != 'S' && c != 'G')
                    {
                        validChars = false;
                        break;
                    }
                }

                if (!validChars)
                    continue;

                int count = 1;
                for (int j = 1; j < sub.Length; j++)
                {
                    if (sub[j] == sub[j - 1])
                    {
                        count++;
                        if (count >= n / 2)
                            return "Yes";
                    }
                    else
                    {
                        count = 1;
                    }
                }
            }
            return "No";
        }
    }
}
