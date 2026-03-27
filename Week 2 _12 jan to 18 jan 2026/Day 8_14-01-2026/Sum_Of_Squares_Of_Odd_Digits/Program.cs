namespace Sum_Of_Squares_Of_Odd_Digits
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter the Number ");
            int input1 = int.Parse(Console.ReadLine());

            NumberOperation obj = new SumOfSquaresOfOddDigits();
            int output = obj.Calculate(input1);

            Console.WriteLine("OUTPUT -> " + output);
        }
    }
}
