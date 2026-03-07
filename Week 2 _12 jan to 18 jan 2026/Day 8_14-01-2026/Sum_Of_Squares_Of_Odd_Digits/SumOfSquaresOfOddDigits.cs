using System;
using System.Collections.Generic;
using System.Text;

namespace Sum_Of_Squares_Of_Odd_Digits
{
    internal class SumOfSquaresOfOddDigits : NumberOperation
    {
        public override int Calculate(int input1)
        {
            if (input1 < 0)
                return -1;

            int sum = 0;

            while (input1 > 0)
            {
                int digit = input1 % 10;
                if (digit % 2 != 0)
                {
                    sum += digit * digit;
                }
                input1 /= 10;
            }

            return sum;
        }
    }
}
