using System;
using System.Collections.Generic;
using System.Text;

namespace Day_5_10_01_2026
{
    internal class PrimeCube
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

        public int SumOfCubes(int n)
        {
            // BR conditions
            if (n < 0 || n > 7)
                return -1;

            int sum = 0;

            for (int i = 1; i <= n; i++)
            {
                if (IsPrime(i))
                {
                    sum += i * i * i;
                }
            }

            return sum;
        }

        static void Main()
        {
            Console.WriteLine("Enter the Number : ");
            int n = int.Parse(Console.ReadLine());
            PrimeCube obj = new PrimeCube();
            int output = obj.SumOfCubes(n);
            Console.WriteLine("Output - > "+ output);
        }
    }
}
