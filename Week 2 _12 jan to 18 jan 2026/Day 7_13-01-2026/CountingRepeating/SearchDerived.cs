using System;
using System.Collections.Generic;
using System.Text;

namespace CountingRepeating
{
    internal class SearchDerived : SearchBase
    {
        // Overridden method with Business Rules
        public override int CountElement(int[] arr, int size, int key)
        {
            if (size < 0)
                return -2;

            if (key < 0)
                return -3;

            for (int i = 0; i < size; i++)
            {
                if (arr[i] < 0)
                    return -1;
            }

            int count = 0;
            for (int i = 0; i < size; i++)
            {
                if (arr[i] == key)
                    count++;
            }

            return count;
        }
    }
}
