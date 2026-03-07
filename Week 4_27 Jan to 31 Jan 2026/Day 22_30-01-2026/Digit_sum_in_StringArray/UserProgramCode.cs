using System;
using System.Collections.Generic;
using System.Text;

namespace Digit_sum_in_StringArray
{
    internal class UserProgramCode
    {
        public static int sumOfDigits(string[] input1)
        {
            int sum = 0;

            foreach (string s in input1)
            {
                foreach (char c in s)
                {
                    if (char.IsDigit(c))
                    {
                        sum += c - '0';
                    }
                    else if (char.IsLetter(c) || c == ' ')
                    {
                        continue;
                    }
                    else
                    {
                        return -1; // special character found
                    }
                }
            }
            return sum;
        }
    }
}
