using System;
using System.Collections.Generic;
using System.IO.Pipelines;
using System.Text;

namespace SumOfCubeOfPrimes
{
    internal class PrimeCubeSum
    {
        public int GetSum(int input1)
        {
            // Business Rules
            if (input1 < 0)
                return -1;

            if (input1 > 32767)
                return -2;

            int sum = 0;

            for (int i = 2; i <= input1; i++)
            {
                if (IsPrime(i))
                {
                    sum += i * i * i; // cube
                }
            }

            return sum;
        }

        private bool IsPrime(int num)
        {
            if (num < 2)
                return false;

            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                    return false;
            }
            return true;
        }
    }
}
