namespace Digit_sum_in_StringArray
{
    internal class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string[] arr = new string[n];

            for (int i = 0; i < n; i++)
            {
                arr[i] = Console.ReadLine();
            }

            int result = UserProgramCode.sumOfDigits(arr);
            Console.WriteLine(result);
        }
    }
}
