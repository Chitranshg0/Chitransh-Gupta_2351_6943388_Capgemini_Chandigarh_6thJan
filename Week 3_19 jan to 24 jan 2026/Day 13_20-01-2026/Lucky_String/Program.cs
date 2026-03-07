namespace Lucky_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string str = Console.ReadLine();

            Console.WriteLine(UserMainCode.CheckLuckyString(n, str));
        }
    }
}
