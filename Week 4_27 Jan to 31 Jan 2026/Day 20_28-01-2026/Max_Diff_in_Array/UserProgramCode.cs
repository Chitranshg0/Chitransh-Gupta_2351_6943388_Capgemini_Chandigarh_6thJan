using System;
using System.Collections.Generic;
using System.Text;

namespace Max_Diff_in_Array
{
    internal class UserProgramCode
    {

        public static int diffIntArray(int[] input1)
        {
            int n = input1.Length;

            // Rule 2
            if (n <= 1 || n > 10)
                return -2;

            HashSet<int> set = new HashSet<int>();

            foreach (int num in input1)
            {
                // Rule 1
                if (num < 0)
                    return -1;

                // Rule 3
                if (!set.Add(num))
                    return -3;
            }

            int minVal = input1[0];
            int maxDiff = input1[1] - input1[0];

            for (int i = 1; i < n; i++)
            {
                if (input1[i] - minVal > maxDiff)
                    maxDiff = input1[i] - minVal;

                if (input1[i] < minVal)
                    minVal = input1[i];
            }

            return maxDiff;
        }
    }
}
