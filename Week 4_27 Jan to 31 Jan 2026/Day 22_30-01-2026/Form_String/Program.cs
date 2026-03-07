namespace Form_String
{
    internal class Program
    {
        static void Main()
        {
            int k = int.Parse(Console.ReadLine());
            string[] arr = new string[k];

            for (int i = 0; i < k; i++)
                arr[i] = Console.ReadLine();

            int n = int.Parse(Console.ReadLine());

            string output = UserProgramCode.formString(arr, n);
            Console.WriteLine(output);
        }
    }
}
