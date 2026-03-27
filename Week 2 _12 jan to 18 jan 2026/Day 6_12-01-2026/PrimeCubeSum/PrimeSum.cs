using System;
using System.Collections.Generic;
using System.Text;

namespace PrimeCubeSum
{
    internal class PrimeSum
    {
        bool IsPrime(int n)
        {
            if (n <= 1)
                return false;

            for (int i = 2; i <= n / 2; i++)
            {
                if (n % i == 0)
                    return false;
            }
            return true;
        }

        public int FindSum(int n)
        {
            if (n < 0)
                return -1;

            if (n > 32676)
                return -2;

            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                if (IsPrime(i))
                    sum += i * i * i;
            }
            return sum;
        }

       
    }
}
