namespace MahirlAndMath
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine());
            int result = UserMainCode.MinOperations(N);
            Console.WriteLine(result);
        
    }
    }
}