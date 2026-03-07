using System;
using System.Collections.Generic;
using System.Text;

namespace Total_Marks
{
    internal class UserMainCode
    {
        public static void CheckMarks(int X, int Y, int N1, int N2, int M)
        {
            bool isValid = false;
            int type1 = 0, type2 = 0;

            for (int i = N1; i >= 0; i--) // maximize Type 1 questions
            {
                for (int j = 0; j <= N2; j++)
                {
                    if ((i * X) + (j * Y) == M)
                    {
                        type1 = i;
                        type2 = j;
                        isValid = true;
                        goto result;
                    }
                }
            }

        result:
            if (isValid)
            {
                Console.WriteLine("Valid");
                Console.WriteLine(type1);
                Console.WriteLine(type2);
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }
    }
}
