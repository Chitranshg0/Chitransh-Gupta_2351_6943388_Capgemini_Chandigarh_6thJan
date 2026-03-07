//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace Day_4_09_01_2026
//{
//    internal class q10
//    {
//        public int[] FindMostRepeated(int[] arr, int size)
//        {
//            int maxCount = 0;
//            for (int i = 0; i < size; i++)
//            {
//                int count = 1;
//                for (int j = i + 1; j < size; j++)
//                {
//                    if (arr[i] == arr[j])
//                        count++;
//                }
//                if (count > maxCount)
//                    maxCount = count;
//            }
//            int resultSize = 0;
//            for (int i = 0; i < size; i++)
//            {
//                int count = 1;
//                for (int j = i + 1; j < size; j++)
//                {
//                    if (arr[i] == arr[j])
//                        count++;
//                }
//                if (count == maxCount)
//                {
//                    bool alreadyAdded = false;
//                    for (int k = 0; k < i; k++)
//                    {
//                        if (arr[k] == arr[i])
//                        {
//                            alreadyAdded = true;
//                            break;
//                        }
//                    }
//                    if (!alreadyAdded)
//                        resultSize++;
//                }
//            }

//            int[] output = new int[resultSize];
//            int index = 0;
//            for (int i = 0; i < size; i++)
//            {
//                int count = 1;
//                for (int j = i + 1; j < size; j++)
//                {
//                    if (arr[i] == arr[j])
//                        count++;
//                }
//                if (count == maxCount)
//                {
//                    bool alreadyAdded = false;
//                    for (int k = 0; k < index; k++)
//                    {
//                        if (output[k] == arr[i])
//                        {
//                            alreadyAdded = true;
//                            break;
//                        }
//                    }
//                    if (!alreadyAdded)
//                        output[index++] = arr[i];
//                }
//            }

//            return output;
//        }

//        static void Main()
//        {
//            Console.WriteLine("Enter the size of array : ");
//            int size = int.Parse(Console.ReadLine());
//            int[] input = new int[size];
//            Console.WriteLine("Enter the elements  of array : ");
//            for (int i = 0; i < size; i++)
//                input[i] = int.Parse(Console.ReadLine());

//            q10 obj = new q10();
//            int[] output = obj.FindMostRepeated(input, size);

//            for (int i = 0; i < output.Length; i++)
//                Console.Write(output[i] + " ");
//        }
//    }
//}
