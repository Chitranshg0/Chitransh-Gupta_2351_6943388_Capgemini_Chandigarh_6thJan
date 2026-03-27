using System;
using System.Collections.Generic;
using System.Text;

namespace Convert_Roman_To_Decimal
{
    internal class UserProgramCode
    {

        public static int convertRomanToDecimal(string input)
        {
            Dictionary<char, int> map = new Dictionary<char, int>()
        {
            {'I',1},{'V',5},{'X',10},{'L',50},
            {'C',100},{'D',500},{'M',1000}
        };

            int total = 0, prev = 0;

            for (int i = input.Length - 1; i >= 0; i--)
            {
                if (!map.ContainsKey(input[i])) return -1;

                int curr = map[input[i]];
                if (curr < prev)
                    total -= curr;
                else
                {
                    total += curr;
                    prev = curr;
                }
            }
            return total;
        }
    }
}
