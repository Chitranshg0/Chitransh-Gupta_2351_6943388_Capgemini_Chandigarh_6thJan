using System;
using System.Collections.Generic;
using System.Text;

namespace Day_5_10_01_2026
{
    internal class RemoveDuplicates
    {
        public int[] RemoveDuplicateElements(int[] input1, int input2)
        {
            if (input2 < 0)
            {
                return new int[] { -2 };
            }

            for (int i = 0; i < input2; i++)
            {
                if (input1[i] < 0)
                {
                    return new int[] { -1 };
                }
            }

            int[] temp = new int[input2];
            int count = 0;

            for (int i = 0; i < input2; i++)
            {
                bool isDuplicate = false;
                for (int j = 0; j < count; j++)
                {
                    if (temp[j] == input1[i])
                    {
                        isDuplicate = true;
                        break;
                    }
                }
                if (!isDuplicate)
                {
                    temp[count++] = input1[i];
                }
            }

            int[] output = new int[count];
            for (int i = 0; i < count; i++)
                output[i] = temp[i];

            return output;
        }

        static void Main()
        {
            Console.WriteLine("Enter the size  of array : ");
            int input2 = int.Parse(Console.ReadLine());
            int[] input1 = new int[input2];
            Console.WriteLine("Enter the elements  of array : ");
            for (int i = 0; i < input2; i++)
                input1[i] = int.Parse(Console.ReadLine());

            RemoveDuplicates obj = new RemoveDuplicates();
            int[] output = obj.RemoveDuplicateElements(input1, input2);
            Console.WriteLine("array : ");
            for (int i = 0; i < output.Length; i++)
                Console.Write(output[i] + " ");
        }
    }
}
