//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace Day_4_09_01_2026
//{
//    internal class q3
//    {
//        public int CountDigits(int n)
//        {
//            if (n < 0)
//                return -1;

//            if (n == 0)
//                return 1;

//            int count = 0;
//            while (n > 0)
//            {
//                count++;
//                n /= 10;
//            }
//            return count;
//        }

//        static void Main()
//        {
//            Console.WriteLine("Enter the no.");
//            int n = int.Parse(Console.ReadLine());
//            q3 o = new q3();
//            Console.WriteLine("No. of Digits");
//            int output1 = o.CountDigits(n);
//            Console.WriteLine(output1);
//        }
//    }
//}
