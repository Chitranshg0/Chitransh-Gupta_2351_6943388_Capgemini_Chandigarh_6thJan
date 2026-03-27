using System;
using System.Collections.Generic;
using System.Text;

namespace Multiple_5
{
    internal class AvgDivisibleBy5 : Calculation
    {
        public override int GetAverage(int input1)
        {
            if (input1 < 0)
                return -1;

            int sum = 0, count = 0;

            for (int i = 1; i <= input1; i++)
            {
                if (i % 5 == 0)
                {
                    sum += i;
                    count++;
                }
            }

            return (count > 0) ? sum / count : 0;
        }
    }
}
