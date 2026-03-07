namespace Sum_of_largest_number_in_range
{
    internal class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
                arr[i] = int.Parse(Console.ReadLine());

            int result = UserProgramCode.largestNumber(arr);
            Console.WriteLine(result);
        }
    }

    class UserProgramCode
    {
        public static int largestNumber(int[] input1)
        {
            bool hasNegative = false;
            bool hasZeroOrAbove100 = false;

            HashSet<int> set = new HashSet<int>();

            foreach (int x in input1)
            {
                if (x < 0) hasNegative = true;
                if (x == 0 || x > 100) hasZeroOrAbove100 = true;
                set.Add(x);
            }

            if (hasNegative && hasZeroOrAbove100) return -3;
            if (hasNegative) return -1;
            if (hasZeroOrAbove100) return -2;

            int sum = 0;

            for (int i = 1; i <= 100; i += 10)
            {
                int max = -1;
                foreach (int x in set)
                {
                    if (x >= i && x <= i + 9)
                        if (x > max) max = x;
                }
                if (max != -1)
                    sum += max;
            }
            return sum;
        }
    }
}
