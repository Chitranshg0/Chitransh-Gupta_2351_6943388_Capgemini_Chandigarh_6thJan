//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace Day_4_09_01_2026
//{
//    internal class q4
//    {
//        public int FindAvg(int[] arr, int size)
//        {
//            if (size < 0)
//                return -2;

//            int evenSum = 0, oddSum = 0;

//            for (int i = 0; i < size; i++)
//            {
//                if (arr[i] < 0)
//                    return -1;

//                if (arr[i] % 2 == 0)
//                    evenSum += arr[i];
//                else
//                    oddSum += arr[i];
//            }

//            return (evenSum + oddSum) / 2;
//        }

//        static void Main()
//        {
//            Console.WriteLine("Enter the Size and elements of array");
//            int size = int.Parse(Console.ReadLine());
//            int[] arr = new int[size];

//            for (int i = 0; i < size; i++)
//            {
//                arr[i] = int.Parse(Console.ReadLine());
//            }

//            q4 obj = new q4();
//            int output1 = obj.FindAvg(arr, size);
//            Console.WriteLine("Average -> " + output1);
//        }
//    }
//}
