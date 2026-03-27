using System;
using System.Collections.Generic;
using System.Text;

namespace RemoveRepeated
{
    internal class Remove
    {
        public int[] RemoveDuplicates(int[] input, int size)
        {
            // check negative elements
            for (int i = 0; i < size; i++)
            {
                if (input[i] < 0)
                {
                    return new int[] { -1 };
                }
            }

            int[] temp = new int[size];
            int count = 0;

            for (int i = 0; i < size; i++)
            {
                bool isDuplicate = false;
                for (int j = 0; j < count; j++)
                {
                    if (temp[j] == input[i])
                    {
                        isDuplicate = true;
                        break;
                    }
                }
                if (!isDuplicate)
                {
                    temp[count++] = input[i];
                }
            }

            int[] output = new int[count];
            for (int i = 0; i < count; i++)
                output[i] = temp[i];

            return output;
        }

       
    }
}
