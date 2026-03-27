using System;
using System.Collections.Generic;
using System.Text;

namespace Donations
{
    internal class UserProgramCode
    {
        public static int getDonation(string[] input1, int input2)
        {
            HashSet<string> set = new HashSet<string>();

            foreach (string s in input1)
            {
                // Rule 1: duplicate check
                if (!set.Add(s))
                    return -1;

                // Rule 2: special character check
                foreach (char c in s)
                {
                    if (!char.IsDigit(c))
                        return -2;
                }
            }

            int total = 0;
            string locationCode = input2.ToString();

            foreach (string s in input1)
            {
                string location = s.Substring(3, 3);   // DEF
                if (location == locationCode)
                {
                    int donation = int.Parse(s.Substring(6, 3)); // GHI
                    total += donation;
                }
            }

            return total;
        }
    }
}
