using System;
using System.Collections.Generic;
using System.Text;

namespace RemoveNegative
{
    internal class ArrayOperation
    {
        public int[] ProcessArray(int[] arr, int size)
        {
            // Business Rule
            if (size < 0)
                return new int[] { -1 };

            List<int> list = new List<int>();

            for (int i = 0; i < size; i++)
            {
                if (arr[i] >= 0)
                    list.Add(arr[i]);
            }

            list.Sort();
            return list.ToArray();
        }
    }
}
