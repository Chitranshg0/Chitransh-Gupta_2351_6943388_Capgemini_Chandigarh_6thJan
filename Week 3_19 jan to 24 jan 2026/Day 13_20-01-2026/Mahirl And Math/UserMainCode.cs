using System;
using System.Collections.Generic;
using System.Text;

namespace MahirlAndMath
{
    internal class UserMainCode
    {
    public static int MinOperations(int N)
    {
        Queue<int> q = new Queue<int>();
        Dictionary<int, int> steps = new Dictionary<int, int>();

        q.Enqueue(10);
        steps[10] = 0;

        while (q.Count > 0)
        {
            int current = q.Dequeue();

            if (current == N)
                return steps[current];

            int[] nextValues = { current + 2, current - 1, current * 3 };

            foreach (int next in nextValues)
            {
                if (next >= 0 && next <= 100000 && !steps.ContainsKey(next))
                {
                    steps[next] = steps[current] + 1;
                    q.Enqueue(next);
                }
            }
        }
        return -1;
    }
}
}
