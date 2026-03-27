using System;
using System.Collections.Generic;
using System.Text;

namespace Multiple_5
{
    internal class Multiple
    {
        public int FindAverage(int[] input1, int input2)
        {
            if (input2 < 0)
                return -2;

            int sum = 0, count = 0;

            for (int i = 0; i < input2; i++)
            {
                if (input1[i] < 0)
                    return -1;

                if (input1[i] % 5 == 0)
                {
                    sum += input1[i];
                    count++;
                }
            }

            if (count == 0)
                return 0;

            return sum / count;   // average
        }

       
    }
}
