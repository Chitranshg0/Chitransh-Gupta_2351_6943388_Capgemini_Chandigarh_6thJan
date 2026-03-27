using System;
using System.Collections.Generic;
using System.Text;

namespace Day_5_10_01_2026
{
    internal class Sum_prime
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

        public int SumOfPrimes(int[] arr, int size)
        {
            if (size < 0)
                return -2;

            int sum = 0;
            bool foundPrime = false;

            for (int i = 0; i < size; i++)
            {
                if (arr[i] < 0)
                    return -1;

                if (IsPrime(arr[i]))
                {
                    sum += arr[i];
                    foundPrime = true;
                }
            }

            if (!foundPrime)
                return -3;

            return sum;
        }

        static void Main()
        {
            Console.WriteLine("Enter the Size : ");
            int size = int.Parse(Console.ReadLine());
            int[] input1 = new int[size];
            Console.WriteLine("Enter the Selements : ");
            for (int i = 0; i < size; i++)
                input1[i] = int.Parse(Console.ReadLine());

            Sum_prime obj = new Sum_prime();
            int output1 = obj.SumOfPrimes(input1, size);
            Console.WriteLine("Output - > " + output1);
        }
    }
}
