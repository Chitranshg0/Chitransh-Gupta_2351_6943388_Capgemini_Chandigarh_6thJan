using System;
using System.Collections.Generic;
using System.Text;

namespace Day_5_10_01_2026
{
    internal class ArrayAddition
    {
        public int[] AddArrays(int[] input1, int[] input2, int input3)
        {
            int[] output = new int[input3];

            if (input3 < 0)
            {
                output[0] = -2;
                return output;
            }

            for (int i = 0; i < input3; i++)
            {
                if (input1[i] < 0 || input2[i] < 0)
                {
                    output[0] = -1;
                    return output;
                }
            }

            for (int i = 0; i < input3; i++)
            {
                output[i] = input1[i] + input2[input3 - 1 - i];
            }

            return output;
        }

        static void Main()
        {
            Console.WriteLine("Enter the size of array : ");
            int input3 = int.Parse(Console.ReadLine());

            int[] input1 = new int[input3];
            int[] input2 = new int[input3];
            Console.WriteLine("Enter the element of array : ");
            for (int i = 0; i < input3; i++)
                input1[i] = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the element  of array : ");
            for (int i = 0; i < input3; i++)
                input2[i] = int.Parse(Console.ReadLine());

            ArrayAddition obj = new ArrayAddition();
            int[] output = obj.AddArrays(input1, input2, input3);
            Console.WriteLine("Sum array : ");
            for (int i = 0; i < output.Length; i++)
                Console.Write(output[i] + " ");
        }
    }
}
