using System;
using System.Collections.Generic;
using System.Text;

namespace SearchElement
{
    internal class ArraySearch
    {
        public int Search(int[] arr, int size, int key)
        {
            // BR: array size negative
            if (size < 0)
                return -2;

            // BR: array contains negative element
            for (int i = 0; i < size; i++)
            {
                if (arr[i] < 0)
                    return -1;
            }

            // Search element
            for (int i = 0; i < size; i++)
            {
                if (arr[i] == key)
                    return 1;   // element found
            }

            // BR: element not found
            return -3;
        }
    }
}
