//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace Day_4_09_01_2026
//{
//    internal class q9
//    {
//        public int Search(int[] arr, int size, int key)
//        {
//            if (size < 0)
//                return -2;

//            for (int i = 0; i < size; i++)
//            {
//                if (arr[i] < 0)
//                    return -1;

//                if (arr[i] == key)
//                    return i;   // location (index)
//            }

//            return 1; // not found
//        }

//        static void Main()
//        {
//            Console.WriteLine("Enter the Size : ");
//            int size = int.Parse(Console.ReadLine());
//            int[] arr = new int[size];
//            Console.WriteLine("Enter the elements : ");
//            for (int i = 0; i < size; i++)
//                arr[i] = int.Parse(Console.ReadLine());

//            Console.WriteLine("Enter the element you want to search : ");
//            int key = int.Parse(Console.ReadLine());

//            q9 obj = new q9();
//            int output1 = obj.Search(arr, size, key);
//            Console.WriteLine( "Index of Element ");
//            Console.WriteLine(output1);
//        }
//    }
//}
