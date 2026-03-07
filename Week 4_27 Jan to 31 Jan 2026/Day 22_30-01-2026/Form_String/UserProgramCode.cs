using System;
using System.Collections.Generic;
using System.Text;

namespace Form_String
{
    internal class UserProgramCode
    {
        public static string formString(string[] input1, int input2)
        {
            // validate special characters
            foreach (string s in input1)
            {
                foreach (char c in s)
                {
                    if (!char.IsLetter(c))
                        return "-1";
                }
            }

            string result = "";
            int index = input2 - 1;

            foreach (string s in input1)
            {
                if (index < s.Length)
                    result += s[index];
                else
                    result += "$";
            }

            return result;
        }
    }
}
