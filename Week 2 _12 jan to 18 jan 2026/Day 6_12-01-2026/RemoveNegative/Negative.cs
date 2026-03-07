using System;
using System.Collections.Generic;
using System.Text;

namespace RemoveNegative
{
    internal class Negative
    {
        public int[] Process(int[] input1, int input2)
        {
            if (input2 < 0)
            {
                return new int[] { -1 };
            }

            int[] temp = new int[input2];
            int count = 0;

            // remove negative values
            for (int i = 0; i < input2; i++)
            {
                if (input1[i] >= 0)
                {
                    temp[count++] = input1[i];
                }
            }

            // copy to exact size array
            int[] output = new int[count];
            for (int i = 0; i < count; i++)
                output[i] = temp[i];

            // sort ascending
            Array.Sort(output);

            return output;
        }

       
    }
}
