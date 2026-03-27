using System;
using System.Collections.Generic;
using System.Text;

namespace SearchRemove
{
    internal class SearchRemoveSort : ArrayOperation
    {
        public override int[] Process(int[] input1, int input2, int input3)
        {
            if (input2 < 0)
                return new int[] { -2 };

            for (int i = 0; i < input2; i++)
            {
                if (input1[i] < 0)
                    return new int[] { -1 };
            }

            int index = -1;
            for (int i = 0; i < input2; i++)
            {
                if (input1[i] == input3)
                {
                    index = i;
                    break;
                }
            }

            if (index == -1)
                return new int[] { -3 };

            int[] output = new int[input2 - 1];
            int k = 0;

            for (int i = 0; i < input2; i++)
            {
                if (i != index)
                    output[k++] = input1[i];
            }

            Array.Sort(output);
            return output;
        }
    }
}
