//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace Day_4_09_01_2026
//{
//    internal class q6
//    {
//        static void Main(string[] args)
//        {
//            int[] arr1 = { 1, 5, 3, 7 };
//            int[] arr2 = { 2, 4, 6, 1 };

//            int n = arr1.Length;
//            int[] output = new int[n];

//            if (n < 0)
//            {
//                output[0] = -2;
//            }
//            else
//            {

//                for (int i = 0; i < n; i++)
//                {
//                    if (arr1[i] < 0 || arr2[i] < 0)
//                    {
//                        output[0] = -1;
//                        Console.WriteLine(output[0]);
//                        return;
//                    }
//                }

//                for (int i = 0; i < n; i++)
//                {
//                    if (arr1[i] > arr2[i])
//                        output[i] = arr1[i];
//                    else
//                        output[i] = arr2[i];
//                }
//            }

//            Console.WriteLine("Output Array:");
//            for (int i = 0; i < n; i++)
//            {
//                Console.Write(output[i] + " ");
//            }
//        }
//    }
//}
