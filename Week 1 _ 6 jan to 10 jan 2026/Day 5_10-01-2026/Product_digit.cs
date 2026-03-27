using System;
using System.Collections.Generic;
using System.Text;

namespace Day_5_10_01_2026
{
    internal class Product_digit
    {
        public int CheckProduct(int n)
        {
            if (n < 0)
                return -1;

            if (n % 3 == 0 || n % 5 == 0)
                return -2;

            int product = 1;
            while (n > 0)
            {
                int d = n % 10;
                product *= d;
                n /= 10;
            }

            if (product % 3 == 0 || product % 5 == 0)
                return 1;
            else
                return 0;
        }

        static void Main()
        {
            Console.WriteLine("Enter the number : ");
            int input1 = int.Parse(Console.ReadLine());
            Product_digit obj = new Product_digit();
            int output = obj.CheckProduct(input1);

            Console.WriteLine("Output - > " + output);
        }
    }
}
