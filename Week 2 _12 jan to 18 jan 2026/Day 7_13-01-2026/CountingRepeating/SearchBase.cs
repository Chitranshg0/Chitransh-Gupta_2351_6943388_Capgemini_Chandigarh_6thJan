using System;
using System.Collections.Generic;
using System.Text;

namespace CountingRepeating
{
    internal class SearchBase
    {
        public int CountElement(int[] arr, int key)
        {
            int count = 0;
            foreach (int x in arr)
            {
                if (x == key)
                    count++;
            }
            return count;
        }

        // Virtual method
        public virtual int CountElement(int[] arr, int size, int key)
        {
            return 0;
        }
    }

    }

