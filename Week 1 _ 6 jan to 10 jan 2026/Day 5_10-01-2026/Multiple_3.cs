using System;
using System.Collections.Generic;
using System.Text;

namespace Day_5_10_01_2026
{
    internal class Multiple_3
    {
        public int CountMultiples(int[] arr, int size)
        {
            if (size < 0)
                return -2;

            int count = 0;
            for (int i = 0; i < size; i++)
            {
                if (arr[i] < 0)
                    return -1;

                if (arr[i] % 3 == 0)
                    count++;
            }
            return count;
        }

        static void Main()
        {
            Console.WriteLine("Enter the size of array : ");
            int size = int.Parse(Console.ReadLine());
            int[] input1 = new int[size];
            Console.WriteLine("Enter the elements of array : ");
            for (int i = 0; i < size; i++)
                input1[i] = int.Parse(Console.ReadLine());

            Multiple_3 obj = new Multiple_3();
            int output = obj.CountMultiples(input1, size);
            Console.WriteLine("Multiple of three :");
            Console.WriteLine(output);
        }
    }
}
