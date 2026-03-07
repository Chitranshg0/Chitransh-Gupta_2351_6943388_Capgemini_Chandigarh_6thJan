namespace Max_Diff_in_Array
{
    internal class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
                arr[i] = int.Parse(Console.ReadLine());

            int result = UserProgramCode.diffIntArray(arr);
            Console.WriteLine(result);
        }
    }
}
