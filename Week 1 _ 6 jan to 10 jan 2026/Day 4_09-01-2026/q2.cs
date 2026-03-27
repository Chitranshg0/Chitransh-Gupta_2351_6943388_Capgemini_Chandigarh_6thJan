//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace Day_4_09_01_2026
//{
//    internal class q2
//    {
//        public int CheckArmstrong(int n)
//        {

//            if (n < 0)
//                return -1;
//            else if (n > 999)
//                return -2;

//            int temp = n, sum = 0;
//            while (temp > 0)
//            {
//                int d = temp % 10;
//                sum += d * d * d;
//                temp /= 10;
//            }

//            if (sum == n)
//                return 1;
//            else
//                return 0;
//        }

//        static void Main()
//        {
//            Console.WriteLine("Enter the Number : ");
//            int n = int.Parse(Console.ReadLine());
//            q2 obj = new q2();
//            int output1 = obj.CheckArmstrong(n);
//            Console.WriteLine(output1);
//        }
//    }
//}
