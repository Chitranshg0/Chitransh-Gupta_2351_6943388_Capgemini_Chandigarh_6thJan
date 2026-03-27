using System;
using System.Collections.Generic;
using System.Text;

namespace Count_of_Elements
{
    internal class UserProgramCode
    {
        public static int GetCount(int size, string[] arr, char ch)
        {
            int count = 0;

            foreach (string s in arr)
            {
                foreach (char c in s)
                {
                    if (!char.IsLetter(c))
                        return -2;
                }

                if (s.StartsWith(ch.ToString(), StringComparison.OrdinalIgnoreCase))
                    count++;
            }

            return count == 0 ? -1 : count;
        }
    }
}
