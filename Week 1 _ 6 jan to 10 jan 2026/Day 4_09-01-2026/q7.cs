//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace Day_4_09_01_2026
//{
//    internal class q7
//    {
//        public int MultiplyPositives(int[] arr, int size)
//        {
//            if (size < 0)
//                return -2;

//            int product = 1;
//            bool foundPositive = false;

//            for (int i = 0; i < size; i++)
//            {
//                if (arr[i] > 0)
//                {
//                    product *= arr[i];
//                    foundPositive = true;
//                }
//            }

//            if (!foundPositive)
//                return 0;

//            return product;
//        }

//        static void Main()
//        {
//            Console.WriteLine("Enter the size  : ");
//            int size = int.Parse(Console.ReadLine());
//            int[] arr = new int[size];
//            Console.WriteLine("Enter the elements of array : ");
//            for (int i = 0; i < size; i++)
//                arr[i] = int.Parse(Console.ReadLine());

//            q7 obj = new q7();
//            int output1 = obj.MultiplyPositives(arr, size);
//            Console.WriteLine(output1);
//        }
//    }
//}
