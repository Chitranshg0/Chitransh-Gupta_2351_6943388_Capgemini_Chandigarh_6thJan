using System;
using System.Collections.Generic;
using System.Text;

namespace Day_5_10_01_2026
{
    internal class Perfect
    {
        public int CheckPerfect(int n)
        {
            if (n < 0)
                return -2;

            int sum = 0;
            for (int i = 1; i <= n / 2; i++)
            {
                if (n % i == 0)
                    sum += i;
            }

            if (sum == n && n != 0)
                return 1;
            else
                return -1;
        }

        static void Main()
        {
            Console.WriteLine("Enter the Number : ");
            int input = int.Parse(Console.ReadLine());
            Perfect obj = new Perfect();
            int output = obj.CheckPerfect(input);
            Console.WriteLine(output);
        }

    }
}
