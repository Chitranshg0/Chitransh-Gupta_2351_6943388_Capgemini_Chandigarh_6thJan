namespace Donations
{
    internal class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string[] arr = new string[n];

            for (int i = 0; i < n; i++)
                arr[i] = Console.ReadLine();

            int locationCode = int.Parse(Console.ReadLine());

            int result = UserProgramCode.getDonation(arr, locationCode);
            Console.WriteLine(result);
        }
    }
}
