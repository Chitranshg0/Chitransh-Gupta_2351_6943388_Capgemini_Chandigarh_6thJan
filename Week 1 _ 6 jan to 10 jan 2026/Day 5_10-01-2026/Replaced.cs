using System;
using System.Collections.Generic;
using System.Text;

namespace Day_5_10_01_2026
{
    internal class Replaced
    {
        public int[] ProcessArray(int[] input1, int input2)
        {
            int[] output1 = new int[input2];

            if (input2 < 0)
            {
                output1[0] = -2;
                return output1;
            }

            if (input2 % 2 == 0)
            {
                output1[0] = -3;
                return output1;
            }

            for (int i = 0; i < input2; i++)
            {
                if (input1[i] < 0)
                {
                    output1[0] = -1;
                    return output1;
                }
            }

            int mid = input2 / 2;

            // swap first with last, second with second last, etc.
            for (int i = 0; i < input2; i++)
            {
                output1[i] = input1[input2 - 1 - i];
            }

            return output1;
        }

        static void Main()
        {
            Console.WriteLine("ENter the size of array ");
            int input2 = int.Parse(Console.ReadLine());
            int[] input1 = new int[input2];
            Console.WriteLine("ENter the elements of array ");

            for (int i = 0; i < input2; i++)
                input1[i] = int.Parse(Console.ReadLine());

            Replaced obj = new Replaced();
            int[] output1 = obj.ProcessArray(input1, input2);
            Console.WriteLine("Output of array ");
            for (int i = 0; i < output1.Length; i++)
                Console.Write(output1[i] + " ");
        }
    }
}
