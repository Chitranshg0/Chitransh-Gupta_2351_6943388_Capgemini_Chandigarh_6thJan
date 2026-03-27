using System;
using System.Collections.Generic;
using System.Text;

namespace List_the_elements
{
    internal class UserProgramCode
    {
        public static List<int> GetElements(List<int> input1, int input2)
        {
            List<int> result = new List<int>();

            foreach (int x in input1)
            {
                if (x < input2)
                    result.Add(x);
            }

            if (result.Count == 0)
            {
                result.Add(-1);
                return result;
            }

            result.Sort();
            result.Reverse(); // descending order
            return result;
        }
    }
}
