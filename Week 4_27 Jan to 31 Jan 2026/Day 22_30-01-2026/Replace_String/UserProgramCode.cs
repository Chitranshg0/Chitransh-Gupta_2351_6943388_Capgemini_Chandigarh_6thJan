using System;
using System.Collections.Generic;
using System.Text;

namespace Replace_String
{
    internal class UserProgramCode
    {
        public static string replaceString(string input1, int input2, char input3)
        {
            // Rule 1: input1 should contain only alphabets and spaces
            foreach (char c in input1)
            {
                if (!char.IsLetter(c) && c != ' ')
                    return "-1";
            }

            // Rule 2: input2 should be positive
            if (input2 <= 0)
                return "-2";

            // Rule 3: input3 should be a special character
            if (char.IsLetterOrDigit(input3))
                return "-3";

            string[] words = input1.Split(' ');

            if (input2 > words.Length)
                return input1.ToLower();

            int index = input2 - 1;
            words[index] = new string(input3, words[index].Length);

            return string.Join(" ", words).ToLower();
        }
    }
}
