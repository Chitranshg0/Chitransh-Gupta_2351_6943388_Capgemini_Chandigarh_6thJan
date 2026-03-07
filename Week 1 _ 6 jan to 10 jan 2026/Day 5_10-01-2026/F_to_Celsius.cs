using System;
using System.Collections.Generic;
using System.Text;

namespace Day_5_10_01_2026
{
    internal class F_to_Celsius
    {
        public int Convert(int f)
        {
            if (f < 0)
                return -1;

            int celsius = (f - 32) * 5 / 9;
            return celsius;
        }

        static void Main()
        {
            Console.WriteLine("Enter the temperature: ");
            int input = int.Parse(Console.ReadLine());
            F_to_Celsius obj = new F_to_Celsius();
            int output = obj.Convert(input);
            Console.WriteLine("Output - > " + output);
        }
    }
}
