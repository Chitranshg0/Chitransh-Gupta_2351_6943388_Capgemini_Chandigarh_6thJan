//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace Day_4_09_01_2026
//{
//    internal class q8
//    {
//        public int SumEvenDigits(int n)
//        {
//            if (n < 0)
//                return -1;

//            if (n > 32767)
//                return -2;

//            int sum = 0;
//            while (n > 0)
//            {
//                int d = n % 10;
//                if (d % 2 == 0)
//                    sum += d;
//                n /= 10;
//            }
//            return sum;
//        }

//        static void Main()
//        {
//            Console.WriteLine("Enter the no. ");
//            int n = int.Parse(Console.ReadLine());
//            q8 obj = new q8();
//            int output1 = obj.SumEvenDigits(n);
//            Console.WriteLine(output1);
//        }
//    }
//}
