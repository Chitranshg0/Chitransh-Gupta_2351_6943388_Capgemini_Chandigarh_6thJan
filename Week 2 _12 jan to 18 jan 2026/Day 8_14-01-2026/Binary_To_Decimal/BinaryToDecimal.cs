using System;
using System.Collections.Generic;
using System.Text;

namespace Binary_To_Decimal
{
    internal class BinaryToDecimal
    {
        static void Main()
        {
            Console.WriteLine("Enter the Binary number : ");
            int input1 = int.Parse(Console.ReadLine());
            int output;

            string bin = input1.ToString();

            if (input1 > 11111)
            {
                output = -2;
            }
            // Rule i: check binary
            else
            {
                bool isBinary = true;
                foreach (char c in bin)
                {
                    if (c != '0' && c != '1')
                    {
                        isBinary = false;
                        break;
                    }
                }

                if (!isBinary)
                {
                    output = -1;
                }
                else
                {
                    int decimalValue = 0;
                    int power = 1;

                    for (int i = bin.Length - 1; i >= 0; i--)
                    {
                        decimalValue += (bin[i] - '0') * power;
                        power *= 2;
                    }

                    output = decimalValue;
                }
            }

            Console.WriteLine("Decimal No : " + output);
        }
    }
}
