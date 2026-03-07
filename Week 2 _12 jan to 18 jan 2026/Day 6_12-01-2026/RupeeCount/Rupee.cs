using System;
using System.Collections.Generic;
using System.Text;

namespace RupeeCount
{
    internal class Rupee
    {
        public int CountNotes(int amount)
        {
            if (amount < 0)
                return -1;

            int count = 0;

            count += amount / 500;
            amount %= 500;

            count += amount / 100;
            amount %= 100;

            count += amount / 50;
            amount %= 50;

            count += amount / 10;
            amount %= 10;

            count += amount / 1;

            return count;
        }

    }
}
