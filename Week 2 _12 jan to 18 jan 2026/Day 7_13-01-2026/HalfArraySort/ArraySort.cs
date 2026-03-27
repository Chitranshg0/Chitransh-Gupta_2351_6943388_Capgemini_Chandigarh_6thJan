using System;
using System.Collections.Generic;
using System.Text;

namespace HalfArraySort
{
    internal class ArraySort
    {
        public int[] SortHalf(int[] arr, int size)
        {
            // Business Rule
            if (size < 0)
                return new int[] { -1 };

            int mid = size / 2;

            // Sort first half ascending
            Array.Sort(arr, 0, mid);

            // Sort second half ascending first
            Array.Sort(arr, mid, size - mid);

            // Reverse second half to make it descending
            Array.Reverse(arr, mid, size - mid);

            return arr;
        }
    }
}
